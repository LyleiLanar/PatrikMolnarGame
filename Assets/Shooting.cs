using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] float ammo;
    void Update()
    {
        //Shoot();

    }

    private void Start()
    {
        //Negyzetszamok(10);
        ParatlanSzamok(100);
    }

    void ParatlanSzamok(int n)
    {
        for (int i = 1; i <= n; i += 2)
        {
            Debug.Log(i);
        }
    }

    void Negyzetszamok(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Debug.Log(i * i);
        }
    }

    private void Shoot()
    {
        bool isShooting = Input.GetKeyDown(KeyCode.Space);
        bool isReloading = Input.GetKeyDown(KeyCode.R);

        bool hasAmmo = ammo > 0;

        if (isShooting)
        {
            if (hasAmmo)
            {
                string shotSound = "Tyú!!";
                float attack = Random.value;

                if (attack > 0.9f)
                {
                    Debug.Log(shotSound + " " + "Headshot!");
                }
                else if (attack > 0.5f)
                {
                    Debug.Log(shotSound + " " + "Találat!");
                }
                else
                {
                    Debug.Log(shotSound + " " + "Mellé!");
                }

                ammo--;
            }
            else
            {
                Debug.Log("Katt...");
            }
        }

        if (isReloading)
        {
            Debug.Log("Újratöltés!!!");
            ammo = 10;
        }

    }
}
