using UnityEngine;

namespace Game.LoadSystem
{
    public sealed class SceneLoader : MonoBehaviour, ILoader
    {
        [SerializeField] private SceneLoadMode _mode;
        [SerializeField] private ScreenFade _screen;
        private readonly GameState _gameState = new();
        private ILoader[] _loaders;

        private void Start()
        {
            _gameState.SetPause(false);
            _loaders = new ILoader[2];
            _loaders[0] = new StandartLoader();

            if (_screen != null)
                _loaders[1] = new FadeLoader(_screen);
        }

        public void Load(SceneData scene)
        {
            var modeIndex = (int) _mode;
            _loaders[modeIndex].Load(scene);
        }
    }

    public enum SceneLoadMode
    {
        Standart,
        Fade
    }

    public interface ILoader
    {
        public void Load(SceneData scene);
    }
}
