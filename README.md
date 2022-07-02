# MV-LiveSplit-GUI
GUI tools for RPGMMV-LiveSplit

# Features
 - One-click installation/updates of the RPGMMV-LiveSplit plugin
 - Manage enabled autosplitter split points
 - Create and edit autosplitter split points

# Usage
Download and extract the [latest release](https://github.com/samjones246/MV-LiveSplit-GUI/releases/latest/download/MV-LiveSplit-GUI.zip), and run `MV-LiveSplit-GUI.exe`. Below is an overview of the interfaces available in the application.
### Main Window
![Main Interface Diagram](/images/interface-main.png)

1. **Status Indicator**  
Once a game has been opened, this label will update to state whether the plugin is installed, missing, or out of date.

2. **Install Button**  
If a game is open and the plugin has been detected as either missing or out of date, this button will be enabled. Clicking it will install the latest version of the plugin.

3. **Add Button**  
With a game open, click this button to create a new split point. This will open the Split Point Editor.

4. **Edit Button**  
With a game open and a split point selected, click this button to edit the selected split point. This will open the Split Point Editor.

5. **Delete Button**  
With a game open and a split point selected, deletes the selected split point. You will be prompted to confirm this decision.

6. **Open Game Button**  
Click to open a folder chooser dialog, which allows you to select the game you wish to manage. Make sure to select the root folder of a valid RPG Maker MV game. This is the folder where the game executable is located, as well as the the `www` folder. If no `www` folder is present, as is the case for some MV games, the game is incompatible with this plugin.

7. **Save Button**  
Becomes enabled when a game is open and changes have been made to split points. Click to save changes, writing them to the Autosplitter file for the active game. Changes will not take effect until you have clicked this button to save them.

8. **Split Points List**   
Contains a list of the split points defined in the autosplitter for the active game. Each entry in the list shows the name of the split point beside a checkbox. The checkbox can be used to toggle whether that split is enabled, and will trigger LiveSplit to split when playing.


### Split Point Editor
This interface appears after clicking the **Add** or **Edit** buttons on the Main Window. It is only necessary to access this interface if you are creating or updating an autosplitter for a game; there is no need to use these features if you just want to customise the enabled split points for an existing autosplitter.

![Split Point Editor](/images/interface-spe.png)

1. **Split Point Name**  
Editable text field used to set the name of the split point being edited.

2. **Default Checkbox**  
Controls whether this split point is enabled by default. This just determines whether the split point will be enabled when a user initially installs the autosplitter, it does not override user preferences which are specified by checking/unchecking split points in the Main Window.

3. **Start Checkbox**  
Controls whether this split point acts as a start point. If checked, the default behaviour of starting timer when the 'New Game' button is pressed on the main menu will be disabled, and instead the timer will start when this split point is triggered.

4. **Add Activator Button**  
Adds a new Activator to this split point, creating a panel in the Activators list below which can be used to configure this Activator. An Activator defines a point in the game which should be linked to this split point. Many split points will only require a single activator, but in cases where there are mutliple actions the player could take which would trigger the same event (e.g. a door to another area is mutliple tiles wide, and each tile is a seperate event with the same code), mutliple activators are required. Each activator has a field called Type, and the value of this field determines which other fields the activator requires. The different types and their fields are explained below.

5. **Activator Type: Transition**  
Triggered by a change in the currently active map. This activator type has two fields:
    - From - Map ID from which the player is transitioning
    - To - Map ID to which the player is transitioning  
<br>

6. **Activator Type: Switch**  
Triggered by a change in the value of a switch. This activator has three fields:
    - Switch ID - Numerical ID of the target switch
    - Any - If true, this activator is triggered by any change in the status of the switch, regardless of whether the switch is being set to ON or OFF.
    - Value - If *Any* is not enabled, the activator is only triggered when the target switch is set to the value of this field, either ON or OFF.  
<br>

7. **Activator Type: Variable**
Triggered by a change in the value of a variable. This activator has three fields:
    - Variable ID - Numerical ID of the target variable
    - Any - If true, this activator is triggered by any change in the value of the variable, regardless of what that value is.
    - Value - If *Any* is not enabled, the activator is only triggered when the target variable is set to the value of this field.  
<br>

8. **Activator Type: Event**  
Triggered upon a line of event code being executed. This activator has five fields:
    - Common - If enabled, specifies  that the target event is a common event. Disables the *Map ID* and *Page* fields.
    - Map ID - Map where the (non-common) target event is located
    - Event ID - ID of the target event
    - Page - Page of the (non-common) target event where the target line is located
    - Line - A zero-indexed line number in the target page's code. The activator will be triggered immediately before this line is executed. If set to -1, the activator will trigger after all lines in the page have been executed.  
<br>

9. **Activator Type: New Game**  
Triggered upon clicking the 'New game' button in the main menu. This activator has no fields. Used for categories in which you return to the main menu during the run.

10. **Cancel Button**  
Closes the Split Point Editor, discarding any changes made, and discarding the split point entirely if the window was opened by clicking the Add button on the Main Window.

11. **OK Button**  
Closes the Split Point Editor, applying any changes made. This does not apply the changes to the file on disk, only to the active session. It is stil necessary to click the Save button on the Main Window to write changes to disk.

### Notes for Autosplitter Developers
 - To find the line number of a line of event code: select the code by pressing CTRL+A, right click and then choose 'Copy as Text', then paste into a text editor which shows line numbers, such as Notepad++ or VS Code. Find the line number of the line you're interested in, and remember to subtract 1 unless the line numbering starts at zero in your editor.
 - When transitioning from one area to another, there is usually a fadeout, followed by the teleport, followed by a fade back in. When using a transition activator, be aware that the split point will trigger in the middle of this black screen, rather than the moment that the player interacts with the door/pathway/etc which triggers the transition. If the desired behaviour is to split on the interaction, use an event split.