using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public class AtomDefaultValuesEditor : EditorWindow
    {
        /// <summary>
        /// Create the editor window.
        /// </summary>
        [MenuItem("Tools/Unity Atoms/Default Values")]
        static void Init()
        {
            var window = GetWindow<AtomDefaultValuesEditor>(false, "Unity Atoms - Default Values");
            window.position = new Rect(Screen.width / 2, Screen.height / 2, 440, 540);
            window.Show();
        }

        /// <summary>
        /// Render variables onto screen
        /// </summary>
        private void OnGUI()
        {
            GUILayout.Label("The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx.", EditorStyles.helpBox);
            AtomDefaultValues.ReplayBufferSize = EditorGUILayout.IntSlider("Replay Buffer Size", AtomDefaultValues.ReplayBufferSize, 0, 10);
        }
    }
}
