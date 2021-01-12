# Devlog for Animation Version 0.1

## Sunday 10 January 2021, 08:57

Start creating a Sit behaviour

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.ProjectBrowser_Animation_Sitting_v0.1_132547707730000000.png)

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.SceneView_Animation_Sitting_v0.1_132547708740000000.png)

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.GameView_Animation_Sitting_v0.1_132547709810000000.png)

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.InspectorWindow_Animation_Sitting_v0.1_132547710050000000.png)

## Sunday 10 January 2021, 09:06

Ensure the characters feet are on the floot

### Details
Try setting foot IK (https://docs.unity3d.com/Manual/InverseKinematics.html)
- Create positions for the feet in the chair model
- Create a Humanoid IK Control script position the feet on the IK Handles
- Set the Left/Right foot positions in the inspector
- Turn on IK in the Sitting test script
- Set IKController in the test script
- Turn on IK Pass
- Play and adjust the position of the IK handles

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.SceneHierarchyWindow_Animation_Sitting_v0.1_132547717430000000.png)

![Screenshot](F:\Unity Projects\WizardsCode\Animation\DevLog\ScreenCaptures\UnityEditor.InspectorWindow_Animation_Sitting_v0.1_132547719760000000.png)

