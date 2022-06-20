
using UnityEngine;

public class ShowTeleportAreaFix : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDisable()
    {
        this.gameObject.SetActive(true);
        Invoke(nameof(InvTru),0.01f);
    }

    // Update is called once per frame
    void InvTru()
    {
        this.gameObject.SetActive(true);
    }
    void LateUpdate() { gameObject.SetActive(true); }
}
