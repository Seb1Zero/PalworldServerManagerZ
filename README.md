# Palworld Server Manager - Simple Server creating and managing tool.    

> [!NOTE]
This is newly forked and I'm working on it at the moment. For now deleted the Palserversettings Editor which made the Manager usable again. 

> [!IMPORTANT]
> It is recommended that you use the backup feature TianYu implemented in update `v1.0.4` and beyond to backup your saved files just in case updating your game server causes a loss of player progression.

> [!NOTE]
In order to use Discord Webhook, you need to fill in your **`Webhook URL`** and save it.    
To test to see if its set up properly, fill in **`Embed Title`** with **`Test123`** or whatever, then save it and press the **`Test`** button.    
Some Webhook notification features do require you to connect to your RCON. You can do that by going to RCON Section, fill out the RCON details then connect to RCON and leave it connected.


_Installation_
-----------------------
1) Download    
2) Create a new folder    
3) Copy the exe to the new folder    
4) Run the exe    

To allow others to join your server and use the rcon feature remotely, you'll need to configure your firewall to open specific ports and set up port forwarding for those ports.   
Basically:   
`Add Server & RCON port to firewall`   
`Portforward your Server & RCON port.`   

|  Default Ports|Description  |
|--|--|
| 8211 |Server Port  |
| 27015 |Steam Port  |
| 25575 |RCON Port  |

   
Could also open ur firewall ports with script: 
```
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
```


_Old-Previews-of-TianYu_
-----------------------

**`v1.1.5 Server Settings Preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/ecc453e8-b2ba-49e7-ab6d-934219177adc" alt="Image1" style="width: 100%; height: auto;">   

**`v1.1.7 Discord Webhook Preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/7d4b8dc7-4d6e-497b-9df1-cf6cedd3e469" alt="Image1" style="width: 100%; height: auto;">   



Official way to create dedicated server: https://tech.palworldgame.com/dedicated-server-guide    

_Credits_
---------------
[Palworld-Rcon-Sharp](https://github.com/calico-crusade/palworld-rcon-sharp)    
[TroubleChute](https://hub.tcno.co/games/palworld/dedicated_server/)   
[Palworld Server Manager](https://github.com/TianYu-00/PalworldServerManager)   




