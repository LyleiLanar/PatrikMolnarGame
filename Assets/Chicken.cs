using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject Egg;
    private void Update()
    {
        PutAnEgg();
    }

    void PutAnEgg()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject go = Instantiate(Egg, Random.insideUnitSphere + new Vector3(0, 4, 0), Random.rotation);

        }
    }
}
