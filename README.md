# Stardust SDK

## Description
This project is designed to showcase the capabilities of Neogoma's Stardust SDK. It aims to provide users with a comprehensive understanding of the library and its features. The project is a unity project that showcases all the aspects of the SDK.

## Use cases scenes

* Scan a map: [Mapping](https://github.com/Neogoma/stardust-SDK/blob/master/Assets/Scenes/Mapper.unity) scene
* Relocate and update on a map: [Relocate-Update](https://github.com/Neogoma/stardust-SDK/blob/master/Assets/Scenes/Relocate-Update.unity) scene
* Update a map only: [Updater](https://github.com/Neogoma/stardust-SDK/blob/master/Assets/Scenes/Updater.unity) scene

## Documentation

The documentation for this project can be found [here](https://doc.neogoma.com). It offers detailed information on various aspects of the Stardust SDK, including installation instructions, usage examples, API references, and troubleshooting tips. It is recommended to consult the documentation as the primary resource for understanding and utilizing Stardust.

## Video Tutorials

A series of video tutorials has been created to assist users in getting started with Stardust. The complete playlist can be found on [YouTube](https://www.youtube.com/watch?v=JlvmCc8EhAE&list=PLSIDrt7N4JB7CX15_06XeceT0wjVwlOmT&pp=iAQB). These tutorials cover various topics, ranging from basic setup and configuration to advanced usage scenarios. Watching the videos will provide valuable insights and practical demonstrations of Stardust SDK's capabilities.

## Issue Tracking

If you encounter any bugs, have questions, or would like to suggest improvements for Stardust, please visit the issue tracker on GitHub. You can open a new issue to report problems or share your feedback. Make sure to provide detailed information about the issue or suggestion, including steps to reproduce if applicable. The project maintainers and the community will actively monitor the issue tracker and provide assistance as needed.

## License

This project is licensed under the MIT License. Please review the license file for more information.

## Changelog

# Update log

## 1.141
* **Plugin**
  * Reduce the memory footprint of the offline mapping

## 1.14
* **Plugin**
  * Adjusting object creation coordinates
  * Offline mapper now returns the name of the map on map creation

## 1.13
* **Plugin**
    * feature: update the navigation plugin to handle unconnected batches

## 1.12
* **Plugin**
    * fix: correct the data coming from lidar devices

## 1.11
* **Plugin**
    * fix: the first picture now becomes the origin of the map
    * fix: offline mapping now sends HD data for all android phones **(premium feature)**

## 1.1
* **Dashboard (premium feature)**
    * feat: allow the creation of composite maps

## 1.0
* **SDK**
    * feat: update data capture for 3D meshing
* **Dashboard**
    * feat: keyboard navigation on editor
    * feat: increased editor loading speed
    * feat: 3D model of the space can now be viewed in the editor
* **API (premium feature)**
    * feat: download 3D model of the scanned space

## 0.91
* **SDK (premium feature)**
    * feat: Allowing offline update

## 0.905
* **SDK (premium feature)**
    * update: Renaming methods for offline mapping

## 0.902
* **SDK**
    * feature: URL's can now be used for displaying pictures
* **Dashboard**
    * feature: allowing users to choose between image URL or GLB upload
* **API (premium feature)**
    * feature: Create a picture via API

## 0.901
* **SDK**
    * fix: correct the bug on different object creation

## 0.9
* **SDK**
    * feature: Adding the scripts for offline mapping
* **API (premium feature)**
    * feature: Download point cloud function 
    * feature: Get map batch data

## 0.85
* **SDK**
    * feature: Sending necessary data for analytics
* **Dashboard**
    * feature: Analytics editor for paying users

## 0.81
* **SDK**
    * fix: object rotation on relocation
    * fix: multiple object creations on the map download

## 0.8
* **SDK**
    * feature: Using GLB files
* **Dashboard**
    * update: Updating the object upload page to manage GLB files
    * update: Editor upgrade
    * feature: Allow users to download their failed relocation pictures (premium feature)
    
## 0.772
* **SDK**
    * update: Updating to Hobodream 1.6

## 0.771
* **SDK**
    * update: Updating the Object management method names to show the MVC structure
    * fix: Correcting the update coordinates after relocation
    * update: Adding methods in object controller to manage the metadata

## 0.77
* **SDK**
    * update: Adding metadata field in the persistent object's data.

## 0.76
* **SDK**
    * update: Adding the property `RelocationReliable` on the relocation results to feedback user on the relocation results

## 0.75
* **SDK**
    * update: Increasing relocation accuracy

## 0.7
* **SDK**
    * feature: Set up call back for maximum number of requests
    * feature: Allow relocation without downloading the map    

## 0.65
* **SDK**
    * update: Reducing capture memory leaks
    * update: Updating the file structure to allow custom data provider (for non AR foundation data)

## 0.622
* **SDK**
    * Udpate the emergency switch rate
    * Update the capture algorithm

## 0.621
* **SDK**
    * Updating the delay between 2 captures
    * Adjusting the emergency cut behavior

## 0.62
* **SDK**
    * Solving cached point cloud issue on Unity editor
    * Manual timeout to server call
    * Updating the capture algorithm

## 0.611
* **SDK**
    * Solving issue on **MapDataUploader**

## 0.61
* **SDK**
    * Adjusting camera resolution fetching   
    
## 0.6
* **SDK**
    * Updating the data capture paramether
    * Editor tools to work on a local scene without online editor

## 0.56 
* **SDK**
    * Updating the data capture parameters
    * Devs can now check how many pictures are queued

## 0.55 "Hawkeye"
* **SDK**
    * Updating the data capture method

## 0.53
* **SDK**
    * Creating a store account for App store
    * Updating to the latest hobodream package
* **Editor**
    * Upgrade editor to Unity 2020.2.x, you can now create your bundles on Unity 2020
    * Update the datas cache to make the map display faster

## 0.52
* **SDK**
    * Fixed a memory leak by blocking the data capture
    * Making relocation faster by reducing amount of data required

## 0.51
* **SDK**
    * Creating GetDataForMap that uses a map UUID rather than a session object

## 0.5 "Constellation"
* **SDK**
    * Upgrade to Unity 2020.2.x and ARFoundation    
    * Increase data resolution: we increased the volume of data extracted from pictures, this will result in longer upload times and longer relocation times
    * Updated the relocation algorithm: data 
    * Point cloud: extract and send point cloud datas to server
    * Memory management: reduced the memory consuption of the SDK on phone  
    * Send data at any coordinates: allow the **MapDataUploader** to send datas at other origins than (0,0,0), if you want to send data after relocating you can now do it
    * Send object at any coordinates: following previous point, we also allow users to create objects in Unity space or in map space.
    * Cross-platform mapping/relocation: Android phones can relocate on IPhone maps and vice versa
    * Renamed **MatchingPosition** to **RelocationResults**
    * **MapRelocationManager.onPositionFound** now triggers an even with **RelocationResults** and a **CoordinateSystem**
* **Editor**
    * Fast manipulation shortcuts
    * Display the point cloud
    * Update objects and target icons on the mini map
    * Target constraints: if you try to position targets too far from the navigation path, the target won't be saved and 
* **Dashboard**
    * Mail registration confirmation: if you are an already existing user you will need to login into the dashboard to confirm your mail adress

## 0.3 "New year"
* **SDK**
    * OBJ file management: allow developers to download or load __OBJ__     
* **Editor**
    * Asset viewer: we added an asset viewer on the API to allow users to preview the objects online
    * Multiple objects selection: the user can select multiple objects in scene or in the object list
    * Objects transformation on scene: Object can be scaled/rotated/moved directly from the scene
 
## 0.2 "Pathfinder"
* **SDK**
    * Navigations system: adding the **NavigationComponents** prefab and the **PathFindingManager**
    * API Token: replace login only with API token with the **StardustSDK** class setup
* **Editor**
    * Full redesign: update the design and the UX of the editor
    * Navigation targets edition: you can now edit the map to add navigations targets
