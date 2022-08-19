using UnityEngine;
public class ProgressControl : MonoBehaviour {
    void Update() {
        // Update progress from 0.0 to 1.0 over the first 15 seconds
        float time_progress = Time.time / 15.0f;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetFloat("_Progress", time_progress);
    }
}
