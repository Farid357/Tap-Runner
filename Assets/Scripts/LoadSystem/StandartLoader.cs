using UnityEngine.SceneManagement;

namespace Game.LoadSystem
{
    public class StandartLoader : ILoader
    {
        public void Load(SceneData sceneData)
        {
            SceneManager.LoadSceneAsync(sceneData.name);
        }
    }
}
