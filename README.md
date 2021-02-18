# Unity-ARFoundation-echoAR-demo-Face-Makeup

Simple face makeup demo with Unity, AR Foundation, and echoAR

## Register

Don't have an API key? Make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup

- Create a new Unity project.
- Clone the [Unity-ARFoundation-echoAR](https://github.com/echoARxyz/Unity-ARFoundation-echoAR) sample code.
- Open the sample scene under `AR Foundation\Scenes\FaceTracking\FaceMesh.unity`.
- [Set your API key](https://docs.echoar.xyz/unity/using-the-sdk) in `echoAR.cs` inside the `echoAR\echoAR.prefab` using the the inspector.
- Select `AR Session Origin` in the hierarchy. Double click `FaceMeshPrefab` under `AR Face Manager` in the inspector. Set `Material Size` to 1
- [Add an image hologram](https://docs.echoar.xyz/web-console/manage-pages/content-page/how-to-add-content) by uploading the *[makeup.png](https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/images/makeup.png)* file from the [images](https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/tree/main/images) folder to the echoAR console.
- Overwrite the existing *echoAR/CustomBehaviour.cs* script with the new [*CustomBehaviour.cs*](https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/CustomBehaviour.cs) file.

## Create Makeup Texture

Make sure to use an **Alpha transparent texture** as a custom shader. The example texture contains eye shadows, eye liners, highlight, lipstick or other coloring. When running the app, it detects a face and overlays the face material. 

To create a makeup texture on your own, open the *[.psd](https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/model/canonical_face_texture.psd)* file in the [model](https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/model) folder. This model is provided by Google [ARCore Augmented Faces Demo](https://developers.google.com/ar/develop/developer-guides/creating-assets-for-augmented-faces)

<img src="https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/demo/model.png" height=40% width=40%>

## Learn more

Refer to our [documentation](https://docs.echoar.xyz/unity/) to learn more about how to use Unity and echoAR.

## Support

Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE).

## Screenshot

<img src="https://github.com/VivianVKJ/Unity-ARFoundation-echoAR-Face-Makeup/blob/main/demo/record.gif" height=30% width=30%>
