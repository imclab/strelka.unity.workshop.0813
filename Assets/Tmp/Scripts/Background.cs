using UnityEngine;

[ExecuteInEditMode]
public class Background : MonoBehaviour
{
    private void Update()
    {
        var cam = Camera.main;
        if (cam == null) return;

        var dist = Mathf.Lerp(cam.nearClipPlane, cam.farClipPlane, .5f);
        transform.position = cam.transform.position + cam.transform.forward*dist;
        transform.rotation = cam.transform.rotation;
        transform.localScale = new Vector3(dist*Mathf.Tan(cam.fieldOfView*Mathf.Deg2Rad*.5f)*cam.aspect*2, dist*Mathf.Tan(cam.fieldOfView*Mathf.Deg2Rad*.5f)*2, 1);
    }
}