# ECN Base Code

## Description 
This project contains a base code showing how to read XR Inputs using the new Unity Input System

# Getting Started

To get Started:
- open the Scene SampleScene
- make sure that you have set a default runtime for OpenXR
- Oculus settings for Oculus Headsets
- Steam VR settings for other Headsets (also works with Oculus Headsets)
- run the Scene
- you should see Inputs values logged in Unity's Console

## Dependancies

This project is using following dependancies:
- XR Plugin Management
- OpenXR
- InputSystem


## Architecture

There are three components used in the SampleScene:
- ActionMapEnabler
- TrackedPoseDriver (New Input System)
- XRInputDebugger
	
ActionMapEnabler:
this component takes a reference to a InputActionAsset file (one can be found in Settings folder) and is used to enable inputs configured on the file

TrackedPoseDriver:
this component is used to link a Transform and Position/Rotation inputs from a XR device (Headset or Controllers)

XRInputDebugger:
this component takes a reference to a InputActionReference to:
- bind events on Button Inputs
- read values Inputs (Axis and Vector2 for now, to be extended)
InputActionReference are created by setting inputs on the InputActionAsset

The main GameObject of SampleScene is XRRig and holds ActionMapEnabler component.
In his childs you'll find 3 Transforms:
- Head
- LeftHand
- RightHand
Each of thoses Transforms holds a TrackedPoseDriver so they're linked to a XR device and Head has a Camera as child

Each Hand GameObject has a few childs:
- Visual which is just a mesh to see where is the Hand
- Trigger which holds a XRInputDebugger configured to log Trigger value
- Grab which holds a XRInputDebugger configured to log Grab value
- Joystick which holds a XRInputDebugger configured to log Joystick value
- Menu which holds a XRInputDebugger configured to trigger an Event when Menu button is pressed or released


## Documentation

To create a new InputActionAsset or edit an existing one, follow the steps described on this link:
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.3/manual/ActionAssets.html

If you created a new InputActionAsset, don't forget to link it on a ActionMapEnabler componnent or you won't get any inputs

Once you've created new InputActionReference, just link them on XRInputDebugger and values or events should be displayed in the console
- you may need to edit XRInputDebugger script for this point to add new expectedControlType (only Axis and Vector2 are done for now)
