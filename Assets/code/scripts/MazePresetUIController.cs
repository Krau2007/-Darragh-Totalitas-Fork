using UnityEngine;
using UnityEngine.UIElements;

public class MazePresetUIController : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;
    [SerializeField] private MazePlacementManager placementManager;

    private Button[] _buttons = new Button[3];
    private VisualElement[] _images = new VisualElement[3];
    private Label[] _labels = new Label[3];

    private void Awake()
    {
        if (uiDocument == null) uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        for (int i = 0; i < 3; i++)
        {
            _buttons[i] = root.Q<Button>($"PresetButton{i}");
            _images[i] = root.Q<VisualElement>($"PresetImage{i}");
            _labels[i] = root.Q<Label>($"PresetLabel{i}");
        }

        BindPresets();
    }

    private void BindPresets()
    {
        var presets = placementManager.AvailablePresets;

        for (int i = 0; i < 3; i++)
        {
            int idx = i;

            if (presets != null && idx < presets.Length && presets[idx] != null)
            {
                var preset = presets[idx];
                _labels[idx].text = preset.displayName;

                if (preset.previewImage != null)
                    _images[idx].style.backgroundImage = new StyleBackground(preset.previewImage);

                _buttons[idx].clicked += () => placementManager.TryPlacePreset(preset);
                _buttons[idx].SetEnabled(true);
            }
            else
            {
                _labels[idx].text = "Empty";
                _buttons[idx].SetEnabled(false);
            }
        }
    }
}
