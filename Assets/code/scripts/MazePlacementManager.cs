using UnityEngine;

public class MazePlacementManager : MonoBehaviour
{
    [SerializeField] private Transform placementAnchor;
    [SerializeField] private MazePreset[] availablePresets;

    private GameObject _currentMazeInstance;
    private bool _placementLocked;

    public MazePreset[] AvailablePresets => availablePresets;

    public bool TryPlacePreset(MazePreset preset)
    {
        if (_placementLocked || preset == null || preset.mazePrefab == null || placementAnchor == null)
            return false;

        if (_currentMazeInstance != null)
            Destroy(_currentMazeInstance);

        _currentMazeInstance = Instantiate(
            preset.mazePrefab,
            placementAnchor.position,
            placementAnchor.rotation
        );
        return true;
    }

    public void LockPlacement()
    {
        _placementLocked = true;
    }

    public void UnlockPlacement()
    {
        _placementLocked = false;
    }
}
