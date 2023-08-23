# FRENS-Project

![alt text](https://gateway.pinata.cloud/ipfs/QmeGmoiA8RcXWgkP3kzfhCGwhc6gu3QMbxH8kqg2H11oe3)  

![](https://hackmd.io/_uploads/HkzJZ4ZS3.png)


## NPC Character Development  
### Welcome to the FRENS project, an initiative to create character building tools for Mona worlds. The metaverse can be a lonely place, and we believe that creating lifelike and interactive Non-Player Characters (NPCs) can change the way we interact with these builds. Even basic NPCs can bring a space to life, creating a truly immersive three-dimensional experience that can be both cinematic and educational. 

- **[Master Google Doc](https://docs.google.com/document/d/1n0FLwARSTRZNjAyPzXoeQeP58nY-RgnI9N1HER8Kyiw/edit?usp=sharing)**

- **[FINAL REPORT](https://www.canva.com/design/DAFpsaFIUmY/CjLWFQ98IgIpKXXJR1906g/view?utm_content=DAFpsaFIUmY&utm_campaign=designshare&utm_medium=link&utm_source=publishsharelink)**
  
- **[Project Presentation/Proposal](https://www.canva.com/design/DAFclcatOME/F3wj0k6RMCpvPIj02XOzDA/edit?utm_content=DAFclcatOME&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)**  

- **[FRENS Project V1 Asset Pack](https://drive.google.com/file/d/1-U_AXW6W-e4hedfSdTnT7aVyJExsDOLo/view?usp=drive_link))**  

## Outcomes  
### **Research and compile resources for generating animated NPCs**  
- Develop a Github/Google Doc for access to all resources and assets  
- Hire part time consultation and support.  
- Research the history, terminology, and types of NPCs for professional game development  
- Compile resources on character templates and information on weight map transfers and more.  
- Research and test animation tools in Unity:   
- Reactor tools/triggers,   
- Navmesh Agent integration  
- Test creating enemies and animated obstacles, general background characters, and “dependant” NPC sidekicks.  

![](https://hackmd.io/_uploads/S1hjg4bHh.png)


### Deliverables

**Reactor Based NPC Pack**
Drag and drop .unitypackages of interactive characters using the Mona Reactors. 
Customize your scene with one person, or a whole group using our asset pack.

- **[FRENS Project V1 Asset Pack](https://drive.google.com/file/d/1-U_AXW6W-e4hedfSdTnT7aVyJExsDOLo/view?usp=drive_link))**
- 
Included below are instructions of how to add your own characters and animations to our fully customizable templates.

**Visual Scripting NPC Pack**
Custom built visual scripted NPC templates by Boomboxheads. 
Utilize multiple styles of waypoint finding systems to add direction and purpose to how your characters move around the space.



### Current Progress:
6/11/23
- Created new Github repo for Visual Scripting builds
https://github.com/gm3/Mona_NPCs
- Updated Deliverables
https://github.com/gm3/Mona_NPCs/issues/1
- Met with Memory to discuss Visual Scripting tools and Mona limitations
    - Brainstormed “look at” and “follow” tools, etc.
- Met with Matt and Christian to discuss feedback on the overall grant program
- Discussed with the core Mona team about AINavMesh and Navmesh Obstacle integration into the Mona SDK
- Developed and tested Q/A UI tools -next steps converting to VS and building unity plugin for a user friendly experience.
- Onboarded into Oasis build, Github>Resilio, chose location S
    - tested importing/updating via resilio
    - prepping to upload unity packages - schedule with Memory for final tests/ install
    - https://www.notion.so/YULTEK-f55d2d60595747b7bcbf04ffbbf0ad91?pvs=4#154d31eb6b2d4f59b3241b98e51a0c40
 - Begun humanoid modeling
-Using Mixamo armature for easy integration of animation presets
-We are Creating a simple workflow for retargeting animations and easily placing your model into our NPC presets.
-Designing characters that can easily be accessorized as a host or npc
    - [](https://cdn.discordapp.com/attachments/995412112769822850/1116170930272604262/Unity_DjM3IBTciz.gif)
    - [](https://cdn.discordapp.com/attachments/995412112769822850/1116460115571245056/chrome_Fqn6bcebO0.gif)


5/28/23
- Created Issues list in Github
- Coordinated with other grantees for cross-grant collaboration
- Developed full scope of final deliverables in Issues
- Researching alternatives to NAVmesh tools
    - Umotion - blend additional animation over existing anim
    - Visual State Machine
- Researching retargeting and auto weight transfers/ auto bone placement
    - Riggify
    - https://www.youtube.com/watch?v=Op0AvUChNTo
    - https://www.mixamo.com/#/
- Test video to Mocap tools
    - https://in3d.io/
- Testing “look” and “follow” functions with C#
  [](https://cdn.discordapp.com/attachments/995412112769822850/1109467989654388776/Unity_Klt7W2xs1o.gif)
- Testing “look” and “follow” functions with Visual Scripting
[](https://cdn.discordapp.com/attachments/995412112769822850/1112560869746937906/Unity_gRRotDOFQz.gif)
5/19/23  
- Onboarded Boomboxhead for support and consultation
- Created Github Repo and Unity co-working files
- Reviewed and tested Reactor tools
- Attempted navmesh agent/obstacle integration, studied unity tools for NPC generation
- Built custom robot with custom animations, testing animator tools in Unity
- Attempted to convert C# game script into YAML then Visual Script using ChatGPT
- Reached out to Mona team about VS resources and Unity AI tool integration



# Drag and drop Reactor model tutorial

- **[FRENS Project V1 Asset Pack](https://drive.google.com/file/d/1-U_AXW6W-e4hedfSdTnT7aVyJExsDOLo/view?usp=drive_link))**
- 
- Import unity package
  - Unselect any preexisting mona files from the import
- Find prefabs in the Prefab Folder
  - Drag and drop NPC prefab into your scene

### Character breakdown
![image](https://github.com/gm3/Mona_NPCs/assets/76547085/05439887-9d41-4706-88cc-b62f07758fb3)

Each build has 3 reactors, one to power a larger area trigger, and a left and right trigger.

Robot Variant 2 - Main Parent object
 >Armature  - armature/bones
   >mixamorig:Hips  -  Root node - capsule collider
 >Upper Body  - Mesh
 >Reactor area  -  large green box, larger trigger area
 >Reactor area left - green trigger box to left of character
 >Reactor area right - green trigger box to left of character
### Animator Breakdown
![Unity_k39c1tXuud](https://github.com/gm3/Mona_NPCs/assets/76547085/87d80b33-8b79-4af8-b245-6145af069d0a)

### Reactor Breakdown
![Unity_SQrKdzViCT](https://github.com/gm3/Mona_NPCs/assets/76547085/10fef816-0672-43e3-90af-983184d6eb74)

Each reactor is set up to perform a trigger. Each has its own box collider and has a single trigger upon entry.
You can add more reactors or use bools and floats for more complex character development.

For more info on reactors visit the MONA Docs below:
https://docs.monaverse.com/create/building-spaces/adding-interactivity/reactor-overview

## How to modify the NPC templates
Our FRENS characters are ready to play directly in the world, but if you would like to swap out an animation or character, review the steps below.

### 1. Changing/adding animations
These characters are using the mixamo rig and can easily add a mixamo animation to the character.

#### Downloading Unity.FBX Animation from Mixamo without skin:
a. Go to the Mixamo website (mixamo.com) and create an account if you haven't already. Everything is free.
b. Browse or search for an animation you want to download and select it.
c. Choose the options FBX for Unity and select Without Skin and click "Download".
![image](https://github.com/gm3/Mona_NPCs/assets/76547085/0dc815c0-76af-4d02-a2cc-45f9a7da9798)


#### Importing the animation into Unity:
a. Open your Unity project and navigate to the Assets folder where you want to store the animation.
b. Drag and drop the downloaded Unity.FBX animation file into the Assets folder.
c. Unity will import the animation, and you will see it appear in the project hierarchy.

#### Preparing the FBX file and retargeting the animation:
a. After importing the FBX animation into Unity, locate the imported FBX file in the project hierarchy.
b. Select the FBX file to open its settings in the Inspector window.
c. In the Inspector window, find the "Rig" section.
g. Click on the small circle next to the "Copy From" field to open the popup menu.
h. In the popup menu, select the "lookingbehindavatar" avatar from the available options.
k. Make any additional adjustments or settings in the Inspector as desired.
![Unity_JnQaUIuh1d](https://github.com/gm3/Mona_NPCs/assets/76547085/5b4b839b-0ab5-4b4f-9579-a0075b2e67e7)

#### Swapping out an animation in the Animator
a. Open your Unity project and locate the existing Animator Controller you want to add the animation to in the Project window.
b. Double-click on the Animator Controller to open it in the Animator window.
c. In the Animator window, you will see a default state with an entry arrow pointing to it. This is the starting point of your animation transitions.
d. Click on the animation you are trying to change in the animator, and go over to the inspector. If you select the circle to the right of the tab, it will open a window where you can select your new animation

![Unity_vx8has3Joi](https://github.com/gm3/Mona_NPCs/assets/76547085/5770a640-72f1-4ce0-83d4-a8b0c73905e8)

Thats how to easily swap out an animation!

#### Adding an additional animation into the Animator:
a. Open your Unity project and locate the existing Animator Controller you want to add the animation to in the Project window.
b. Double-click on the Animator Controller to open it in the Animator window.
c. In the Animator window, you will see a default state with an entry arrow pointing to it. This is the starting point of your animation transitions.
d. In the Project window, locate the FBX file containing the desired animation.
e. Drag and drop the animation directly from the FBX file into the Animator window. This will create a new state with the animation.
g. Right-click on the new state and select "Set as Layer Default State" to change the default state of the Animator Controller if needed.
![Unity_LHlnklIvpf](https://github.com/gm3/Mona_NPCs/assets/76547085/ddf473c9-cd7a-4f68-8e6b-b89f53550152)

To copy or redo the transitions similar to the existing setup:
- Select the transition arrow between the default state and the new state.
- In the Inspector window, you can modify the transition settings, such as the conditions, duration, and any other desired parameters.
- To add a condition, click on the plus and add the desired parameter. 
- For this build, we are using triggers, so a parameter is only needed on the transition to your new animation (with NO exit time), and the transition leaving your animation has exit time. This will change if you are using booleans or other types of parameters.
![Unity_w5fW07Rvwa](https://github.com/gm3/Mona_NPCs/assets/76547085/08f3b727-899b-43cf-84ce-6abebd8c226a)


To add new trigger parameters to the Animator:
- In the Animator window, locate the Parameters section on the left side.
- Click on the "+" button to add a new parameter.
- Select "Trigger" as the parameter type.
- Enter a name for the new trigger parameter.
![Unity_99ZaTEEZNQ](https://github.com/gm3/Mona_NPCs/assets/76547085/542ff58a-5c00-4faa-84f7-b2fe44e4ef62)

- Heads up: If you add a new parameter, you will also need to change the name of the trigger in the reactors.
![chrome_RQVCF8a043](https://github.com/gm3/Mona_NPCs/assets/76547085/4db4bd5b-e641-4229-ba23-9bea3a160b01)


h. Adjust any other transition settings or parameters as desired by selecting the transition arrows or states and modifying the properties in the Inspector window.
i. Save the Animator Controller by clicking "File" in the Unity menu and selecting "Save" or by using the keyboard shortcut Ctrl+S (Windows) or Command+S (Mac).
j. Press play in Unity and check if the animation is playing. If you added an animation as a trigger, you can activate the trigger using the parameters in the Animator Controller.

That's it! You have successfully added an animation from an FBX file to an existing Animator in Unity.

## Drag and drop Visual Scripting models
- Import unity package
  - Unselect any preexisting mona files from the import

### Character breakdown
...

### Visual scripting overview
...

### Properly rig model

### Resources

**Modeling tools**
-CATS Blender Plugin - https://github.com/absolute-quantum/cats-blender-plugin
Help assign armature to model, clean and fix rig, and apply the rest/t-pose

-Simplygon - https://www.simplygon.com/
Model optimization and LOD generator. Combine and bake multiple textures, remesh and optimize models

**Animation and Character Resources**
-Mixamo - https://www.mixamo.com/
Free motion capture animations and game models by Adobe

-Actorcore - https://actorcore.reallusion.com/
Motion capture (mocap) animations, beta rigging tool and game models with some free assets

-Text Magic -https://freetools.textmagic.com/text-to-speech
FREE text to mp3 audio generator

### Import into Unity
...

### Setting up the Rig, Avatar, and animations
...

Creating Avatars
...

Creating Animator
...

Creating transitions, parameters
...

Working with Anystate
...

Feel free to modify or adjust these steps based on your specific needs and preferences.


