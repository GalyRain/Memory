using UnityEngine;

namespace Assets
{
    public class  ResourcesLoader
    {
        public Theme GetTheme(string themeName)
        {
            return Resources.Load<Theme>(themeName);
        }
    }
}
