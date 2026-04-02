using UnityEngine;

[CreateAssetMenu(fileName = "MazePreset", menuName = "Totalitas/Maze Preset")]
public class MazePreset : ScriptableObject
{
    public string presetId;
    public string displayName;
    public Sprite previewImage;
    public GameObject mazePrefab;
}