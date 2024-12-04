using UnityEngine;

namespace Models
{
    public class Panel : MonoBehaviour
    {
        public void SetActive(bool value)
        {
            gameObject.SetActive(value);
        }
    }
}