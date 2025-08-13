using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form_ServerSettings : Form
    {
        //
        //Palworld World Server Settings Parameter Description
        //

        private Form1 mainForm;
        private Form_RCON rconForm;
        private Form_DiscordWebHook discordWebhookForm;

        private const string serverSettingsFileName = "ServerSettingsPreset.json";
        private string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private const int MaxLines = 100;


        // BACKUP INTERVAL
        private bool forceBackup = false;
        private string serv_backupInterval;
        private string serv_maxBackup;
        private string serv_backupToDirectory;

        private string serv_autoRestartEvery;
        private string serv_onCMDCrashRestartInterval;

        public string serv_customServerLaunchArgument;

        //RCON Alerts
        private string serv_backupRCONAlertInterval;
        private string serv_backupRCONAlertMessage;

        private string serv_restartServerRCONAlertInterval;
        private string serv_restartServerRCONAlertMessage;


        //Difficulty Adjusts the overall difficulty of the game.
        private string serv_difficulty;

        //DayTimeSpeedRate    Modifies the speed of in-game time during the day.
        private string serv_dayTimeSpeedRate;

        //NightTimeSpeedRate Modifies the speed of in-game time during the night.
        private string serv_nightTimeSpeedRate;

        //ExpRate Changes the experience gain rate for both players and creatures.
        private string serv_expRate;

        //PalCaptureRate Adjusts the rate at which Pal creatures can be captured.
        private string serv_palCaptureRate;

        //PalSpawnNumRate Adjusts the rate at which Pal creatures spawn.
        private string serv_palSpawnNumRate;

        //PalDamageRateAttack Fine-tunes Pal creature damage dealt.
        private string serv_palDamageRateAttack;

        //PalDamageRateDefense Fine-tunes Pal creature damage received.
        private string serv_palDamageRateDefense;

        //PlayerDamageRateAttack Fine-tunes player damage dealt.
        private string serv_playerDamageRateAttack;

        //PlayerDamageRateDefense Fine-tunes player damage received.
        private string serv_playerDamageRateDefense;

        //PlayerStomachDecreaseRate Adjusts the rate at which the player's stomach decreases.
        private string serv_playerStomachDecreaseRate;

        //PlayerStaminaDecreaseRate Adjusts the rate at which the player's stamina decreases.
        private string serv_playerStaminaDecreaseRate;

        //PlayerAutoHPRegeneRate Adjusts the rate of automatic player health regeneration.
        private string serv_playerAutoHpRegenRate;

        //PlayerAutoHpRegeneRateInSleep Adjusts the rate of automatic player health regeneration during sleep.
        private string serv_playerAutoHpRegenRateInSleep;

        //PalStomachDecreaseRate Adjusts the rate at which Pal creature stomach decreases.
        private string serv_palStomachDecreaseRate;

        //PalStaminaDecreaseRate Adjusts the rate at which Pal creature stamina decreases.
        private string serv_palStaminaDecreaseRate;

        //PalAutoHPRegeneRate Adjusts the rate of automatic Pal creature health regeneration.
        private string serv_palAutoHpRegeneRate;

        //PalAutoHpRegeneRateInSleep Adjusts the rate of automatic Pal creature health regeneration during sleep.
        private string serv_palAutoHpRegeneRateInSleep;

        //BuildObjectDamageRate Adjusts the rate at which built objects take damage.
        private string serv_buildObjectDamageRate;

        //BuildObjectDeteriorationDamageRate Adjusts the rate at which built objects deteriorate.
        private string serv_buildObjectDeteriorationDamageRate;

        //CollectionDropRate Adjusts the drop rate of collected items.
        private string serv_collectionDropRate;

        //CollectionObjectHpRate Adjusts the health of collected objects.
        private string serv_collectionObjectHpRate;

        //CollectionObjectRespawnSpeedRate Adjusts the respawn speed of collected objects.
        private string serv_collectionObjectRespawnSpeedRate;

        //EnemyDropItemRate Adjusts the drop rate of items from defeated enemies.
        private string serv_enemyDropItemRate;

        //DeathPenalty Defines the penalty upon player death (e.g., All, None).
        private string serv_deathPenalty;

        //bEnablePlayerToPlayerDamage Enables or disables player-to-player damage.
        private string serv_enablePlayerToPlayerDamage;

        //bEnableFriendlyFire Enables or disables friendly fire.
        private string serv_enableFriendlyFire;

        //bEnableInvaderEnemy Enables or disables invader enemies.
        private string serv_enableInvaderEnemy;

        //bActiveUNKO Activates or deactivates UNKO (Unidentified Nocturnal Knock-off).
        private string serv_activeUNKO;

        //bEnableAimAssistPad Enables or disables aim assist for controllers.
        private string serv_enableAimAssistPad;

        //bEnableAimAssistKeyboard Enables or disables aim assist for keyboards.
        private string serv_enableAimAssistKeyboard;

        //DropItemMaxNum Sets the maximum number of dropped items in the game.
        private string serv_dropItemMaxNum;

        //DropItemMaxNum_UNKO Sets the maximum number of dropped UNKO items in the game.
        private string serv_dropItemMaxNum_UNKO;

        //BaseCampMaxNum Sets the maximum number of base camps that can be built.
        private string serv_baseCampMaxNum;

        //BaseCampWorkerMaxNum Sets the maximum number of workers in a base camp.
        private string serv_baseCampWorkerMaxNum;

        //DropItemAliveMaxHours Sets the maximum time items remain alive after being dropped.
        private string serv_dropItemAliveMaxHours;

        //bAutoResetGuildNoOnlinePlayers Automatically resets guilds with no online players.
        private string serv_autoResetGuildNoOnlinePlayers;

        //AutoResetGuildTimeNoOnlinePlayers Sets the time after which guilds with no online players are automatically reset.
        private string serv_autoResetGuildTimeNoOnlinePlayers;

        //GuildPlayerMaxNum Sets the maximum number of players in a guild.
        private string serv_guildPlayerMaxNum;

        //PalEggDefaultHatchingTime Sets the default hatching time for Pal eggs.
        private string serv_palEggDefaultHatchingTime;

        //WorkSpeedRate Adjusts the overall work speed in the game.
        private string serv_workSpeedRate;

        //bIsMultiplay Enables or disables multiplayer mode.
        private string serv_isMultiplay;

        //bIsPvP Enables or disables player versus player (PvP) mode.
        private string serv_isPvP;

        //bCanPickupOtherGuildDeathPenaltyDrop Enables or disables the pickup of death penalty drops from other guilds.
        private string serv_canPickupOtherGuildDeathPenaltyDrop;

        //bEnableNonLoginPenalty Enables or disables non-login penalties.
        private string serv_enableNonLoginPenalty;

        //bEnableFastTravel Enables or disables fast travel.
        private string serv_enableFastTravel;

        //bIsStartLocationSelectByMap Enables or disables the selection of starting locations on the map.
        private string serv_isStartLocationSelectByMap;

        //bExistPlayerAfterLogout Enables or disables the existence of players after logout.
        private string serv_existPlayerAfterLogout;

        //bEnableDefenseOtherGuildPlayer Enables or disables the defense of other guild players.
        private string serv_enableDefenseOtherGuildPlayer;

        //CoopPlayerMaxNum Sets the maximum number of cooperative players in a session.
        private string serv_coopPlayerMaxNum;

        //ServerPlayerMaxNum Sets the maximum number of players allowed on the server.
        private string serv_serverPlayerMaxNum;

        //ServerName Sets the name of the Palworld server.
        private string serv_serverName;

        //ServerDescription Provides a description for the Palworld server.
        private string serv_serverDescription;

        //AdminPassword Sets the password for server administration.
        private string serv_adminPassword;

        //ServerPassword Sets the password for joining the Palworld server.
        private string serv_serverPassword;

        //PublicPort Sets the public port for the Palworld server.
        private string serv_publicPort;

        //PublicIP Sets the public IP address for the Palworld server.
        private string serv_publicIP;

        //RCONEnabled Enables or disables Remote Console(RCON) for server administration.
        public string serv_rconEnabled;

        //RCONPort Sets the port for Remote Console (RCON) communication.
        public string serv_rconPort;

        //Region Sets the region for the Palworld server.
        private string serv_region;

        //bUseAuth Enables or disables server authentication.
        private string serv_useAuth;

        //BanListURL Sets the URL for the server's ban list.
        private string serv_banListURL;

        //
        private string serv_baseCampMaxNumInGuild;

        //
        private string serv_bInvisibleOtherGuildBaseCampAreaFX;

        //
        private string serv_autoSaveSpan;

        //
        private string serv_RESTAPIEnabled;

        //
        private string serv_RESTAPIPort;

        //
        private string serv_bShowPlayerList;

        //
        private string serv_allowConnectPlatform;

        //
        private string serv_bIsUseBackupSaveData;

        //
        private string serv_logFormatType;

        //
        private string serv_supplyDropSpan;


        /// <summary>
        /// DEFAULT SERVER WORLD SETTINGS
        /// </summary>
        /// 
        private string dserv_backupInterval = "0";
        private string dserv_maxBackup = "0";
        private string dserv_backupToDirectory;

        private string dserv_autoRestartEvery = "0";
        private string dserv_onCMDCrashRestartInterval = "0";

        public string dserv_customServerLaunchArgument = "";

        //RCON ALERTS
        private string dserv_backupRCONAlertInterval = "0";
        private string dserv_backupRCONAlertMessage = "";

        private string dserv_restartServerRCONAlertInterval = "0";
        private string dserv_restartServerRCONAlertMessage = "";

        // SERVER WORLD SETTINGS (Defaults weiterhin vorhanden – werden nur nicht mehr über UI geändert)
        private string dserv_difficulty = "None";
        private string dserv_dayTimeSpeedRate = "1.000000";
        private string dserv_nightTimeSpeedRate = "1.000000";
        private string dserv_expRate = "1.000000";
        private string dserv_palCaptureRate = "1.000000";
        private string dserv_palSpawnNumRate = "1.000000";
        private string dserv_palDamageRateAttack = "1.000000";
        private string dserv_palDamageRateDefense = "1.000000";
        private string dserv_playerDamageRateAttack = "1.000000";
        private string dserv_playerDamageRateDefense = "1.000000";
        private string dserv_playerStomachDecreaseRate = "1.000000";
        private string dserv_playerStaminaDecreaseRate = "1.000000";
        private string dserv_playerAutoHpRegenRate = "1.000000";
        private string dserv_playerAutoHpRegenRateInSleep = "1.000000";
        private string dserv_palStomachDecreaseRate = "1.000000";
        private string dserv_palStaminaDecreaseRate = "1.000000";
        private string dserv_palAutoHpRegeneRate = "1.000000";
        private string dserv_palAutoHpRegeneRateInSleep = "1.000000";
        private string dserv_buildObjectDamageRate = "1.000000";
        private string dserv_buildObjectDeteriorationDamageRate = "1.000000";
        private string dserv_collectionDropRate = "1.000000";
        private string dserv_collectionObjectHpRate = "1.000000";
        private string dserv_collectionObjectRespawnSpeedRate = "1.000000";
        private string dserv_enemyDropItemRate = "1.000000";
        private string dserv_deathPenalty = "All";
        private string dserv_enablePlayerToPlayerDamage = "False";
        private string dserv_enableFriendlyFire = "False";
        private string dserv_enableInvaderEnemy = "True";
        private string dserv_activeUNKO = "False";
        private string dserv_enableAimAssistPad = "True";
        private string dserv_enableAimAssistKeyboard = "False";
        private string dserv_dropItemMaxNum = "3000";
        private string dserv_dropItemMaxNum_UNKO = "100";
        private string dserv_baseCampMaxNum = "128";
        private string dserv_baseCampWorkerMaxNum = "15";
        private string dserv_dropItemAliveMaxHours = "1.000000";
        private string dserv_autoResetGuildNoOnlinePlayers = "False";
        private string dserv_autoResetGuildTimeNoOnlinePlayers = "72.000000";
        private string dserv_guildPlayerMaxNum = "20";
        private string dserv_palEggDefaultHatchingTime = "72.000000";
        private string dserv_workSpeedRate = "1.000000";
        private string dserv_isMultiplay = "False";
        private string dserv_isPvP = "False";
        private string dserv_canPickupOtherGuildDeathPenaltyDrop = "False";
        private string dserv_enableNonLoginPenalty = "True";
        private string dserv_enableFastTravel = "True";
        private string dserv_isStartLocationSelectByMap = "True";
        private string dserv_existPlayerAfterLogout = "False";
        private string dserv_enableDefenseOtherGuildPlayer = "False";
        private string dserv_coopPlayerMaxNum = "4";
        private string dserv_serverPlayerMaxNum = "32";
        private string dserv_serverName = "PSM Default Palworld Server";
        private string dserv_serverDescription = "";
        private string dserv_adminPassword = "";
        private string dserv_serverPassword = "";
        private string dserv_publicPort = "8211";
        private string dserv_publicIP = "";
        private string dserv_rconEnabled = "False";
        private string dserv_rconPort = "25575";
        private string dserv_region = "";
        private string dserv_useAuth = "True";
        private string dserv_banListURL = "https://api.palworldgame.com/api/banlist.txt";
        private string dserv_baseCampMaxNumInGuild = "4";
        private string dserv_bInvisibleOtherGuildBaseCampAreaFX = "False";
        private string dserv_autoSaveSpan = "30.000000";
        private string dserv_RESTAPIEnabled = "False";
        private string dserv_RESTAPIPort = "8212";
        private string dserv_bShowPlayerList = "False";
        private string dserv_allowConnectPlatform = "Steam";
        private string dserv_bIsUseBackupSaveData = "True";
        private string dserv_logFormatType = "Text";
        private string dserv_supplyDropSpan = "180";

        public class ServerSettingsPreset
        {
            // BACKUP INTERVAL
            public string json_backupInterval { get; set; }
            public string json_maxBackup { get; set; }
            public string json_backupToDirectory { get; set; }

            public string json_autoRestartEvery { get; set; }
            public string json_onCMDCraftRestartInterval { get; set; }

            public string json_customServerLaunchArgument { get; set; }

            //RCON ALERT
            public string json_backupRCONAlertInterval { get; set; }
            public string json_backupRCONAlertMessage { get; set; }
            public string json_restartServerRCONAlertInterval { get; set; }
            public string json_restartServerRCONAlertMessage { get; set; }


            //WORLD EDIT (Properties bleiben zur Abwärtskompatibilität im JSON)
            public string json_difficulty { get; set; }
            public string json_dayTimeSpeedRate { get; set; }
            public string json_nightTimeSpeedRate { get; set; }
            public string json_expRate { get; set; }
            public string json_palCaptureRate { get; set; }
            public string json_palSpawnNumRate { get; set; }
            public string json_palDamageRateAttack { get; set; }
            public string json_palDamageRateDefense { get; set; }
            public string json_playerDamageRateAttack { get; set; }
            public string json_playerDamageRateDefense { get; set; }
            public string json_playerStomachDecreaseRate { get; set; }
            public string json_playerStaminaDecreaseRate { get; set; }
            public string json_playerAutoHpRegeneRate { get; set; }
            public string json_playerAutoHpRegeneRateInSleep { get; set; }
            public string json_palStomachDecreaseRate { get; set; }
            public string json_palStaminaDecreaseRate { get; set; }
            public string json_palAutoHpRegeneRate { get; set; }
            public string json_palAutoHpRegeneRateInSleep { get; set; }
            public string json_buildObjectDamageRate { get; set; }
            public string json_buildObjectDeteriorationDamageRate { get; set; }
            public string json_collectionDropRate { get; set; }
            public string json_collectionObjectHpRate { get; set; }
            public string json_collectionObjectRespawnSpeedRate { get; set; }
            public string json_enemyDropItemRate { get; set; }
            public string json_deathPenalty { get; set; }
            public string json_enablePlayerToPlayerDamage { get; set; }
            public string json_enableFriendlyFire { get; set; }
            public string json_enableInvaderEnemy { get; set; }
            public string json_activeUNKO { get; set; }
            public string json_enableAimAssistPad { get; set; }
            public string json_enableAimAssistKeyboard { get; set; }
            public string json_dropItemMaxNum { get; set; }
            public string json_dropItemMaxNum_UNKO { get; set; }
            public string json_baseCampMaxNum { get; set; }
            public string json_baseCampWorkerMaxNum { get; set; }
            public string json_dropItemAliveMaxHours { get; set; }
            public string json_autoResetGuildNoOnlinePlayers { get; set; }
            public string json_autoResetGuildTimeNoOnlinePlayers { get; set; }
            public string json_guildPlayerMaxNum { get; set; }
            public string json_palEggDefaultHatchingTime { get; set; }
            public string json_workSpeedRate { get; set; }
            public string json_isMultiplay { get; set; }
            public string json_isPvP { get; set; }
            public string json_canPickupOtherGuildDeathPenaltyDrop { get; set; }
            public string json_enableNonLoginPenalty { get; set; }
            public string json_enableFastTravel { get; set; }
            public string json_isStartLocationSelectByMap { get; set; }
            public string json_existPlayerAfterLogout { get; set; }
            public string json_enableDefenseOtherGuildPlayer { get; set; }
            public string json_coopPlayerMaxNum { get; set; }
            public string json_serverPlayerMaxNum { get; set; }
            public string json_serverName { get; set; }
            public string json_serverDescription { get; set; }
            public string json_adminPassword { get; set; }
            public string json_serverPassword { get; set; }
            public string json_publicPort { get; set; }
            public string json_publicIP { get; set; }
            public string json_rconEnabled { get; set; }
            public string json_rconPort { get; set; }
            public string json_region { get; set; }
            public string json_useAuth { get; set; }
            public string json_banListURL { get; set; }

            //
            public string json_baseCampMaxNumInGuild { get; set; }

            //
            public string json_bInvisibleOtherGuildBaseCampAreaFX { get; set; }

            //
            public string json_autoSaveSpan { get; set; }

            //
            public string json_RESTAPIEnabled { get; set; }

            //
            public string json_RESTAPIPort { get; set; }

            //
            public string json_bShowPlayerList { get; set; }

            //
            public string json_allowConnectPlatform { get; set; }

            //
            public string json_bIsUseBackupSaveData { get; set; }

            //
            public string json_logFormatType { get; set; }

            //
            public string json_supplyDropSpan { get; set; }
        }


        public Form_ServerSettings(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            rconForm = form.rconForm;
            discordWebhookForm = form.discordWebHookForm;
        }

        private void Form_ServerSettings_Load(object sender, EventArgs e)
        {
            // Keine ComboBox-Hooks mehr (Editor entfernt)
            // CreateServerSettingsJSON();      // JSON anlegen, falls nicht vorhanden
            ReadWorldSettingsFile();         // zeigt nur Dateiinhalt in richTextBox2
            LoadServerSettingsJSON();        // lädt verbleibende Settings

            // Variablen für Timer/Backup initialisieren
            serv_backupInterval = textBox_backupInterval.Text;
            serv_backupToDirectory = textBox_backupTo.Text;
            serv_maxBackup = textBox_maxBackup.Text;
            serv_autoRestartEvery = textBox_autoRestartEvery.Text;
            serv_onCMDCrashRestartInterval = textBox_onServerCmdCrashRestartInterval.Text;
            serv_customServerLaunchArgument = textBox_customServerLaunchArgument.Text;

            // RCON-Alerts
            serv_backupRCONAlertInterval = textBox_backupRCONAlertInterval.Text;
            serv_backupRCONAlertMessage = textBox_backupRCONAlertMessage.Text;
            serv_restartServerRCONAlertInterval = textBox_restartServerRCONAlertInterval.Text;
            serv_restartServerRCONAlertMessage = textBox_restartServerRCONAlertMessage.Text;

            richTextBox_alert.AppendText("" + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult askBeforeSave = MessageBox.Show(
                "Do you want to proceed with saving your server settings?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (askBeforeSave != DialogResult.Yes) return;

            try
            {
                // NUR restliche Settings speichern – KEIN Edit der PalWorldSettings.ini
                WriteServerSettingsJSON();
                ReadWorldSettingsFile(); // Anzeige aktualisieren (rein lesend)

                SendMessageToConsole("Server Settings saved (PalWorldSettings.ini not modified).");
            }
            catch (Exception ex)
            {
                SendMessageToConsole("Saving settings failed: " + ex.Message);
            }
        }

        private void ReadWorldSettingsFile()
        {
            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

            try
            {
                if (File.Exists(iniFilePath))
                {
                    string iniContent = File.ReadAllText(iniFilePath);
                    richTextBox2.Text = iniContent;
                }
                else
                {
                    SendMessageToConsole("WorldSetting file not found");
                }
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Read World Setting File Catched Error: {ex.Message}");
            }
        }

        // Methode bleibt vorhanden, wird aber nicht mehr vom Save-Button genutzt
        private bool WriteWorldSettingsFile()
        {
            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");

            try
            {
                if (File.Exists(iniFilePath))
                {
                    string newWorldSettings = $"[/Script/Pal.PalGameWorldSettings]\n" +
                        $"OptionSettings=(Difficulty={serv_difficulty},DayTimeSpeedRate={serv_dayTimeSpeedRate},NightTimeSpeedRate={serv_nightTimeSpeedRate},ExpRate={serv_expRate},PalCaptureRate={serv_palCaptureRate},PalSpawnNumRate={serv_palSpawnNumRate},PalDamageRateAttack={serv_palDamageRateAttack},PalDamageRateDefense={serv_palDamageRateDefense},PlayerDamageRateAttack={serv_playerDamageRateAttack},PlayerDamageRateDefense={serv_playerDamageRateDefense},PlayerStomachDecreaceRate={serv_playerStomachDecreaseRate},PlayerStaminaDecreaceRate={serv_playerStaminaDecreaseRate},PlayerAutoHPRegeneRate={serv_playerAutoHpRegenRate},PlayerAutoHpRegeneRateInSleep={serv_playerAutoHpRegenRateInSleep},PalStomachDecreaceRate={serv_palStomachDecreaseRate},PalStaminaDecreaceRate={serv_palStaminaDecreaseRate},PalAutoHPRegeneRate={serv_palAutoHpRegeneRate},PalAutoHpRegeneRateInSleep={serv_palAutoHpRegeneRateInSleep},BuildObjectDamageRate={serv_buildObjectDamageRate},BuildObjectDeteriorationDamageRate={serv_buildObjectDeteriorationDamageRate},CollectionDropRate={serv_collectionDropRate},CollectionObjectHpRate={serv_collectionObjectHpRate},CollectionObjectRespawnSpeedRate={serv_collectionObjectRespawnSpeedRate},EnemyDropItemRate={serv_enemyDropItemRate},DeathPenalty={serv_deathPenalty},bEnablePlayerToPlayerDamage={serv_enablePlayerToPlayerDamage},bEnableFriendlyFire={serv_enableFriendlyFire},bEnableInvaderEnemy={serv_enableInvaderEnemy},bActiveUNKO={serv_activeUNKO},bEnableAimAssistPad={serv_enableAimAssistPad},bEnableAimAssistKeyboard={serv_enableAimAssistKeyboard},DropItemMaxNum={serv_dropItemMaxNum},DropItemMaxNum_UNKO={serv_dropItemMaxNum_UNKO},BaseCampMaxNum={serv_baseCampMaxNum},BaseCampWorkerMaxNum={serv_baseCampWorkerMaxNum},DropItemAliveMaxHours={serv_dropItemAliveMaxHours},bAutoResetGuildNoOnlinePlayers={serv_autoResetGuildNoOnlinePlayers},AutoResetGuildTimeNoOnlinePlayers={serv_autoResetGuildTimeNoOnlinePlayers},GuildPlayerMaxNum={serv_guildPlayerMaxNum},PalEggDefaultHatchingTime={serv_palEggDefaultHatchingTime},WorkSpeedRate={serv_workSpeedRate},bIsMultiplay={serv_isMultiplay},bIsPvP={serv_isPvP},bCanPickupOtherGuildDeathPenaltyDrop={serv_canPickupOtherGuildDeathPenaltyDrop},bEnableNonLoginPenalty={serv_enableNonLoginPenalty},bEnableFastTravel={serv_enableFastTravel},bIsStartLocationSelectByMap={serv_isStartLocationSelectByMap},bExistPlayerAfterLogout={serv_existPlayerAfterLogout},bEnableDefenseOtherGuildPlayer={serv_enableDefenseOtherGuildPlayer},CoopPlayerMaxNum={serv_coopPlayerMaxNum},ServerPlayerMaxNum={serv_serverPlayerMaxNum},ServerName=\"{serv_serverName}\",ServerDescription=\"{serv_serverDescription}\",AdminPassword=\"{serv_adminPassword}\",ServerPassword=\"{serv_serverPassword}\",PublicPort={serv_publicPort},PublicIP=\"{serv_publicIP}\",RCONEnabled={serv_rconEnabled},RCONPort={serv_rconPort},Region=\"{serv_region}\",bUseAuth={serv_useAuth},BanListURL=\"{serv_banListURL}\",BaseCampMaxNumInGuild={serv_baseCampMaxNumInGuild},bInvisibleOtherGuildBaseCampAreaFX={serv_bInvisibleOtherGuildBaseCampAreaFX},AutoSaveSpan={serv_autoSaveSpan},RESTAPIEnabled={serv_RESTAPIEnabled},RESTAPIPort={serv_RESTAPIPort},bShowPlayerList={serv_bShowPlayerList},AllowConnectPlatform={serv_allowConnectPlatform},bIsUseBackupSaveData={serv_bIsUseBackupSaveData},LogFormatType={serv_logFormatType},SupplyDropSpan={serv_supplyDropSpan})";
                    File.WriteAllText(iniFilePath, newWorldSettings);
                    return true;
                }
                else
                {
                    SendMessageToConsole("Wirte world setting file error: INI file missing, try running the server once in order to generate the file.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Write world Setting file Catched Error: {ex.Message}");
                return false;
            }
        }

        private void WriteServerSettingsJSON()
        {
            // Nur restliche (Nicht-INI) Einstellungen persistieren
            var settings = new ServerSettingsPreset
            {
                // Backup settings
                json_backupInterval = textBox_backupInterval.Text,
                json_maxBackup = textBox_maxBackup.Text,
                json_backupToDirectory = textBox_backupTo.Text,

                // Auto restart
                json_autoRestartEvery = textBox_autoRestartEvery.Text,
                json_onCMDCraftRestartInterval = textBox_onServerCmdCrashRestartInterval.Text,

                // Server launch argument
                json_customServerLaunchArgument = textBox_customServerLaunchArgument.Text,

                // RCON ALERT
                json_backupRCONAlertInterval = textBox_backupRCONAlertInterval.Text,
                json_backupRCONAlertMessage = textBox_backupRCONAlertMessage.Text,
                json_restartServerRCONAlertInterval = textBox_restartServerRCONAlertInterval.Text,
                json_restartServerRCONAlertMessage = textBox_restartServerRCONAlertMessage.Text
            };

            // Serialize settings to JSON
            string json = JsonSerializer.Serialize(settings);

            // Save JSON to file
            File.WriteAllText(serverSettingsFileName, json);
        }

        private void LoadServerSettingsJSON()
        {
            if (!File.Exists(serverSettingsFileName))
            {
                // Create default settings file once
                return;
            }

            // Read JSON from file
            string json = File.ReadAllText(serverSettingsFileName);

            // Deserialize JSON to settings object
            var settings = JsonSerializer.Deserialize<ServerSettingsPreset>(json);
            if (settings == null) return;

            // Update UI with loaded (Nicht-INI) settings
            // Backup settings
            textBox_backupInterval.Text = settings.json_backupInterval;
            textBox_maxBackup.Text = settings.json_maxBackup;
            textBox_backupTo.Text = settings.json_backupToDirectory;

            // Auto restart
            textBox_autoRestartEvery.Text = settings.json_autoRestartEvery;
            textBox_onServerCmdCrashRestartInterval.Text = settings.json_onCMDCraftRestartInterval;

            // Server launch argument
            textBox_customServerLaunchArgument.Text = settings.json_customServerLaunchArgument;

            // RCON ALERT
            textBox_backupRCONAlertInterval.Text = settings.json_backupRCONAlertInterval;
            textBox_backupRCONAlertMessage.Text = settings.json_backupRCONAlertMessage;
            textBox_restartServerRCONAlertInterval.Text = settings.json_restartServerRCONAlertInterval;
            textBox_restartServerRCONAlertMessage.Text = settings.json_restartServerRCONAlertMessage;

            // Optional interne Variablen (ohne UI) weiter befüllen
            serv_rconEnabled = settings.json_rconEnabled;
            serv_rconPort = settings.json_rconPort;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Button wurde aus dem UI entfernt – Methode belassen (harmlos)
            string iniFilePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "Config", "WindowsServer", "PalWorldSettings.ini");
            OpenFileDirectoryGiven(iniFilePath);
        }

        private void OpenFileDirectoryGiven(string directory)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = directory, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Open file directory given catched Error: {ex.Message}");
            }
        }

        public void SaveGameTimer_Start()
        {
            if (serv_backupInterval != "0" && serv_backupInterval != "")
            {
                try
                {
                    int newInt;
                    bool isSuccessParse;

                    if (int.TryParse(serv_backupInterval, out newInt))
                    {
                        isSuccessParse = true;
                    }
                    else
                    {
                        isSuccessParse = false;
                    }

                    int actualTimer = (newInt * 1000);
                    if (actualTimer < 0 || isSuccessParse == false)
                    {
                        SendMessageToConsole($"save game interval value: {serv_backupInterval} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                        return;
                    }
                    timer1.Interval = actualTimer;
                }
                catch (Exception ex) { SendMessageToConsole($"SaveGameTimer catched error: " + ex.Message); return; }
                timer1.Start();
            }

        }

        public void SaveGameTimer_Stop()
        {
            timer1.Stop();

        }

        private void SaveGame()
        {
            if (serv_backupInterval != "0" && serv_backupInterval != "" || forceBackup == true)
            {
                try
                {
                    string savePath = Path.Combine(baseDirectory, "steamapps", "common", "PalServer", "Pal", "Saved", "SaveGames");
                    if (!string.IsNullOrWhiteSpace(savePath) && !string.IsNullOrWhiteSpace(serv_backupToDirectory))
                    {
                        try
                        {
                            DateTime currentDateTime = DateTime.Now;
                            string currentDateTimeString = currentDateTime.ToString("yyyy_MM_dd_HH_mm_ss");
                            string mainFolderName = new DirectoryInfo(savePath).Name;
                            if (!forceBackup)
                            {
                                // THIS IS AUTO SAVE
                                string autoSaveDestinationMainFolderPath = Path.Combine(serv_backupToDirectory, "SaveFiles", "AutoSave", $"GameSave_{currentDateTimeString}", mainFolderName);
                                Directory.CreateDirectory(autoSaveDestinationMainFolderPath);

                                foreach (string dirPath in Directory.GetDirectories(savePath, "*", SearchOption.AllDirectories))
                                {
                                    Directory.CreateDirectory(dirPath.Replace(savePath, autoSaveDestinationMainFolderPath));
                                }

                                foreach (string newPath in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
                                {
                                    File.Copy(newPath, newPath.Replace(savePath, autoSaveDestinationMainFolderPath), true);
                                }

                                CheckMaxBackup();
                                SendMessageToConsole("Auto Backup completed successfully!");
                                discordWebhookForm.SendEmbed("Notification", "Auto Backup completed successfully!");
                            }
                            else if (forceBackup)
                            {
                                // THIS IS MANUAL SAVE
                                string manualSaveDestinationMainFolderPath = Path.Combine(serv_backupToDirectory, "SaveFiles", "ManualSave", $"GameSave_{currentDateTimeString}", mainFolderName);
                                Directory.CreateDirectory(manualSaveDestinationMainFolderPath);

                                foreach (string dirPath in Directory.GetDirectories(savePath, "*", SearchOption.AllDirectories))
                                {
                                    Directory.CreateDirectory(dirPath.Replace(savePath, manualSaveDestinationMainFolderPath));
                                }

                                foreach (string newPath in Directory.GetFiles(savePath, "*.*", SearchOption.AllDirectories))
                                {
                                    File.Copy(newPath, newPath.Replace(savePath, manualSaveDestinationMainFolderPath), true);
                                }

                                SendMessageToConsole("Manual Backup completed successfully!");
                                discordWebhookForm.SendEmbed("Notification", "Manual Backup completed successfully!");
                            }

                            forceBackup = false;


                        }
                        catch (Exception ex)
                        {
                            SendMessageToConsole($"Save game error catched: {ex.Message}");
                        }

                    }
                    else
                    {
                        SendMessageToConsole($"Failed To Saved, path is null or not found");
                    }
                }
                catch (Exception ex)
                {
                    SendMessageToConsole($"Save game catched error: {ex.Message}");
                }
            }

        }

        private void CheckMaxBackup() //Check max backup and delete oldest until x left.
        {
            int newMaxBackupInt;
            bool isSuccessParse;
            if (int.TryParse(serv_maxBackup, out newMaxBackupInt))
            {
                isSuccessParse = true;
            }
            else
            {
                isSuccessParse = false;
            }

            if (isSuccessParse == false)
            {
                SendMessageToConsole($"Backup threshold value: {serv_maxBackup} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                return;
            }

            if (newMaxBackupInt <= 0)
            {
                return;
            }


            if (Directory.Exists(serv_backupToDirectory))
            {
                string saveFilePath = Path.Combine(serv_backupToDirectory, "SaveFiles", "AutoSave");
                string[] subdirectories = Directory.GetDirectories(saveFilePath);

                while (subdirectories.Length > newMaxBackupInt)
                {
                    var oldestDirectory = subdirectories
                        .Select(d => new DirectoryInfo(d))
                        .OrderBy(d => d.CreationTime)
                        .First();

                    try
                    {
                        oldestDirectory.Delete(true);
                        subdirectories = Directory.GetDirectories(saveFilePath); // Update subdirectories array
                    }
                    catch (Exception ex)
                    {
                        SendMessageToConsole($"Delete old auto backup catched error: {ex.Message}");
                        break;
                    }
                }

                SendMessageToConsole("Older auto backup deleted");
            }
            else
            {
                SendMessageToConsole("Older auto backup Directory does not exist.");
            }
        }

        private void button_backupTo_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    textBox_backupTo.Text = folderBrowserDialog.SelectedPath;
                    serv_backupToDirectory = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button_manualSave_Click(object sender, EventArgs e)
        {
            forceBackup = true;
            SaveGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SaveGame();
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"timer1_autobackup catched error: " + ex.Message);
            }
        }

        private void button_openManualAutoSaveDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string savedDirectory = Path.Combine(serv_backupToDirectory, "SaveFiles");
                Process.Start(new ProcessStartInfo { FileName = savedDirectory, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Open manual save catched error: {ex.Message}");
            }
        }


        public void AutoRestartServerTimer_Start()
        {
            if (serv_autoRestartEvery != "0" && serv_autoRestartEvery != "")
            {
                try
                {
                    int newInt;
                    bool isSuccessParse;

                    if (int.TryParse(serv_autoRestartEvery, out newInt))
                    {
                        isSuccessParse = true;
                    }
                    else
                    {
                        isSuccessParse = false;
                    }

                    int actualTimer = (newInt * 1000);

                    if (actualTimer < 0 || isSuccessParse == false)
                    {
                        SendMessageToConsole($"server restart interval value: {serv_autoRestartEvery} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                        return;
                    }
                    timer2.Interval = actualTimer;
                }
                catch (Exception ex) { SendMessageToConsole($"Restart server timer start catched error{ex.Message}\n Check your server restart intervals, makesure they are a integer value without mistypes"); return; }
                timer2.Start();
            }
        }

        public void AutoRestartServerTimer_Stop()
        {
            timer2.Stop();
        }


        private async void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mainForm.isServerStarted)
                {
                    mainForm.StopServer();
                    await Task.Delay(1000);
                    mainForm.StartServer();
                }
                else
                {
                    SendMessageToConsole("timer2_autorestartserver error: server not started");
                }
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"timer2_autorestartserver catched errror: " + ex.Message);
            }
        }

        public void SendMessageToConsole(string message)
        {
            if (richTextBox_alert.Lines.Length > MaxLines)
            {
                int linesToRemove = richTextBox_alert.Lines.Length - MaxLines;

                for (int i = 0; i < linesToRemove; i++)
                {
                    int indexToRemove = richTextBox_alert.GetFirstCharIndexFromLine(i);
                    int lengthToRemove = richTextBox_alert.GetFirstCharIndexFromLine(i + 1) - indexToRemove;

                    richTextBox_alert.Text = richTextBox_alert.Text.Remove(indexToRemove, lengthToRemove);
                }
            }

            DateTime currentTime = DateTime.Now;
            richTextBox_alert.AppendText($"[{currentTime}] " + message + Environment.NewLine);
            richTextBox_alert.SelectionStart = richTextBox_alert.Text.Length;
            richTextBox_alert.ScrollToCaret();
        }

        public void Start_OnCMDCrashRestartTimer()
        {
            if (serv_onCMDCrashRestartInterval != "0" && serv_onCMDCrashRestartInterval != "")
            {
                try
                {
                    int newInt;
                    bool isSuccessParse;

                    if (int.TryParse(serv_onCMDCrashRestartInterval, out newInt))
                    {
                        isSuccessParse = true;
                    }
                    else
                    {
                        isSuccessParse = false;
                    }

                    int actualTimer = (newInt * 1000);
                    if (actualTimer < 0 || isSuccessParse == false)
                    {
                        SendMessageToConsole($"cmd crash restart interval value: {serv_onCMDCrashRestartInterval} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                        return;
                    }
                    timer_onCMDCrashRestart.Interval = actualTimer;
                }
                catch (Exception ex) { SendMessageToConsole($"cmd crash restart timer catched error: " + ex.Message); return; }
                timer_onCMDCrashRestart.Start();
            }

        }

        public void Stop_OnCMDCrashRestartTimer()
        {
            timer_onCMDCrashRestart.Stop();
        }


        private void timer_onCMDCrashRestart_Tick(object sender, EventArgs e)
        {
            OnCrashRestart();
        }

        private async void OnCrashRestart()
        {
            string processName = "PalServer-Win64-Shipping-Cmd";
            Process palServerProcess = null;

            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                palServerProcess = process;
            }

            if (mainForm.isServerStarted && palServerProcess == null)
            {
                SendMessageToConsole($"Detected server is started but process is not found, attempting to restart server...");
                SendMessageToConsole($"Use 'Stop Server' Button instead if you want to shutdown your server.");
                mainForm.StopServer();
                await Task.Delay(1000);
                mainForm.StartServer();

            }
            else
            {
                // Dont do anything
            }

        }

        private void button_customServerLaunchArgument_Click(object sender, EventArgs e)
        {
            string palworldServerLaunchArgumentList = @"https://tech.palworldgame.com/settings-and-operation/arguments";
            OpenURLGiven(palworldServerLaunchArgumentList);
        }

        private void OpenURLGiven(string URL)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = URL, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Webpage open catched error: {ex.Message}");
            }
        }


        public void BackUpAlertTimer_Start()
        {
            int newInt2;
            bool isSuccessParse2;

            if (int.TryParse(serv_backupInterval, out newInt2))
            {
                isSuccessParse2 = true;
            }
            else
            {
                isSuccessParse2 = false;
            }

            if (serv_backupRCONAlertInterval != "0" && serv_backupRCONAlertInterval != "" && serv_rconEnabled == "True" && serv_backupInterval != "0" && serv_backupInterval != "" && isSuccessParse2)
            {
                try
                {
                    int newInt;
                    bool isSuccessParse;

                    if (int.TryParse(serv_backupRCONAlertInterval, out newInt))
                    {
                        isSuccessParse = true;
                    }
                    else
                    {
                        SendMessageToConsole("Parsing failed. The input string is not in a correct format.");
                        isSuccessParse = false;
                    }

                    int actualTimer = (newInt * 1000);
                    if (actualTimer < 0 || isSuccessParse == false)
                    {
                        SendMessageToConsole($"backup rcon alert timer interval value: {serv_backupRCONAlertInterval} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                        return;
                    }
                    timer_backupRCONAlertTimer.Interval = actualTimer;
                }
                catch (Exception ex) { SendMessageToConsole($"backup rcon alert timer catched error: " + ex.Message); return; }
                timer_backupRCONAlertTimer.Start();
            }
        }

        public void BackUpAlertTimer_Stop()
        {
            timer_backupRCONAlertTimer.Stop();
        }

        public void ServerRestartAlertTimer_Start()
        {
            int newInt2;
            bool isSuccessParse2;

            if (int.TryParse(serv_autoRestartEvery, out newInt2))
            {
                isSuccessParse2 = true;
            }
            else
            {
                isSuccessParse2 = false;
            }

            if (serv_restartServerRCONAlertInterval != "0" && serv_restartServerRCONAlertInterval != "" && serv_rconEnabled == "True" && serv_autoRestartEvery != "0" && serv_autoRestartEvery != "" && isSuccessParse2)
            {
                try
                {
                    int newInt;
                    bool isSuccessParse;

                    if (int.TryParse(serv_restartServerRCONAlertInterval, out newInt))
                    {
                        isSuccessParse = true;
                    }
                    else
                    {
                        SendMessageToConsole("Parsing failed. The input string is not in a correct format.");
                        isSuccessParse = false;
                    }

                    int actualTimer = (newInt * 1000);
                    if (actualTimer < 0 || isSuccessParse == false)
                    {
                        SendMessageToConsole($"server restart alert timer interval value: {serv_restartServerRCONAlertInterval} has failed to parse to a valid positive integer number, make sure you enter a valid value.");
                        return;
                    }
                    timer_restartServerRCONAlertTimer.Interval = actualTimer;
                }
                catch (Exception ex) { SendMessageToConsole($"server restart alert timer catched error: " + ex.Message); return; }
                timer_restartServerRCONAlertTimer.Start();
            }
        }

        public void ServerRestartAlertTimer_Stop()
        {
            timer_restartServerRCONAlertTimer.Stop();
        }

        private void timer_backupRCONAlertTimer_Tick(object sender, EventArgs e)
        {
            rconForm.RCONAlert($"{serv_backupRCONAlertMessage}");
            SendMessageToConsole($"{serv_backupRCONAlertMessage}");
        }

        private void timer_restartServerRCONAlertTimer_Tick(object sender, EventArgs e)
        {
            rconForm.RCONAlert($"{serv_restartServerRCONAlertMessage}");
            SendMessageToConsole($"{serv_restartServerRCONAlertMessage}");
        }
    }
}
