using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float temperature;

    // Start is called before the first frame update
    private void Start()
    {
        temperature = 100;

    }





    // Update is called once per frame
    void Update()
    {


        //computer running at 800 fps..... deltatime will be 1/800=0.00125
        //computer running at 60 fps..... deltatime will be  1/60=0.01667
        //computer running at 10 fps.....deltatime will be 1/10= 0.1

        temperature = temperature - Time.deltaTime;

        if (temperature > 70)
        {
            Debug.Log("The temperature is too hot!" + (int)temperature);
        }
        else if (temperature < 40)

        {
            Debug.Log("The temperature is too cold! " + (int)temperature);
        }
        else
        {
            Debug.Log("The temperature is just right!" + (int)temperature);


        }







        // int charactermovementspeed = 5;

        //transform.position+ vector3.foward*charactermovementspeed






    }

}
