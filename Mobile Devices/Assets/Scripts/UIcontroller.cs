using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    public GameObject animal;
    public GameObject basic;
    public GameObject transport;
    public GameObject airplane;
    public GameObject birds;
    public GameObject trees;





    public GameObject lion;
    public GameObject tiger;
    public GameObject bear;
    public GameObject wolf;
    public GameObject cow;


    public GameObject car;
    public GameObject bus;
    public GameObject truck;
    public GameObject van;
    public GameObject bike;


    public GameObject apple;
    public GameObject banana;
    public GameObject bonsai;
    public GameObject pine;
    public GameObject palm;



    public GameObject parrot;
    public GameObject sparrow;
    public GameObject penguin;
    public GameObject turkey;
    public GameObject rooster;


    public GameObject rocket;
    public GameObject airplane1;
    public GameObject heli;
    public GameObject drone;
    public GameObject fj;

    public GameObject gb;

    public RectTransform rectTransform;
    public List<RectTransform> trans = new List<RectTransform>();

    private void Start()
    {
       
    }

    public void BringOn()
    {
        rectTransform.anchoredPosition = Vector3.zero;
    }

    public void CAtBringOn()
    {
        trans[0].anchoredPosition = Vector3.zero;
    }
    public void catBackBtn()
    {
        trans[0].anchoredPosition = new Vector2(-600f, 600f);
        trans[1].anchoredPosition = new Vector2(-600f, 600f);
        trans[2].anchoredPosition = new Vector2(-600f, 600f);
        trans[3].anchoredPosition = new Vector2(-600f, 600f);
        trans[4].anchoredPosition = new Vector2(-600f, 600f);

    }


    public void BackBtn()
    {
        rectTransform.anchoredPosition = new Vector2(-600f, 600f); 
    }


    public void animalbg()
    {
        animal.SetActive(true);
        basic.SetActive(false);
        airplane.SetActive(false);
        birds.SetActive(false);
        trees.SetActive(false);
        transport.SetActive(false);
    }

    public void transportbg()
    {
        animal.SetActive(false);
        basic.SetActive(false);
        airplane.SetActive(false);
        birds.SetActive(false);
        trees.SetActive(false);
        transport.SetActive(true);
    }

    public void airplanebg()
    {
        animal.SetActive(false);
        basic.SetActive(false);
        airplane.SetActive(true);
        birds.SetActive(false);
        trees.SetActive(false);
        transport.SetActive(false);
    }

    public void basicbg()
    {
        animal.SetActive(false);
        basic.SetActive(true);
        airplane.SetActive(false);
        birds.SetActive(false);
        trees.SetActive(false);
        transport.SetActive(false);
    }

    public void birdbg()
    {
        animal.SetActive(false);
        basic.SetActive(false);
        airplane.SetActive(false);
        birds.SetActive(true);
        trees.SetActive(false);
        transport.SetActive(false);
    }

    public void treebg()
    {
        animal.SetActive(false);
        basic.SetActive(false);
        airplane.SetActive(false);
        birds.SetActive(false);
        trees.SetActive(true);
        transport.SetActive(false);
    }


    public void Lion()
    {
        trans[0].anchoredPosition = Vector3.zero;
        lion.SetActive(true);
        tiger.SetActive(false);
        bear.SetActive(false);
        wolf.SetActive(false);
        cow.SetActive(false);
    }
    public void Tiger()
    {
        trans[0].anchoredPosition = Vector3.zero;
        lion.SetActive(false);
        tiger.SetActive(true);
        bear.SetActive(false);
        wolf.SetActive(false);
        cow.SetActive(false);
    }

    public void Bear()
    {
        trans[0].anchoredPosition = Vector3.zero;
        lion.SetActive(false);
        tiger.SetActive(false);
        bear.SetActive(true);
        wolf.SetActive(false);
        cow.SetActive(false);
    }

    public void Wolf()
    {
        trans[0].anchoredPosition = Vector3.zero;
        lion.SetActive(false);
        tiger.SetActive(false);
        bear.SetActive(false);
        wolf.SetActive(true);
        cow.SetActive(false);
    }

    public void Cow()
    {
        trans[0].anchoredPosition = Vector3.zero;
        lion.SetActive(false);
        tiger.SetActive(false);
        bear.SetActive(false);
        wolf.SetActive(false);
        cow.SetActive(true);
    }

    public void Car()
    {
        trans[1].anchoredPosition = Vector3.zero;
        bus.SetActive(false);
        bike.SetActive(false);
        van.SetActive(false);
        truck.SetActive(false);
        car.SetActive(true);
    }
    public void Bus()
    {
        trans[1].anchoredPosition = Vector3.zero;
        bus.SetActive(true);
        bike.SetActive(false);
        van.SetActive(false);
        truck.SetActive(false);
        car.SetActive(false);
    }
    public void Van()
    {
        trans[1].anchoredPosition = Vector3.zero;
        bus.SetActive(false);
        bike.SetActive(false);
        van.SetActive(true);
        truck.SetActive(false);
        car.SetActive(false);
    }
    public void MotorCycle()
    {
        trans[1].anchoredPosition = Vector3.zero;
        bus.SetActive(false);
        bike.SetActive(true);
        van.SetActive(false);
        truck.SetActive(false);
        car.SetActive(false);
    }
    public void Truck()
    {
        trans[1].anchoredPosition = Vector3.zero;
        bus.SetActive(false);
        bike.SetActive(false);
        van.SetActive(false);
        truck.SetActive(true);
        car.SetActive(false);
    }
    public void Banana()
    {
        trans[2].anchoredPosition = Vector3.zero;
        banana.SetActive(true);
        apple.SetActive(false);
        bonsai.SetActive(false);
        pine.SetActive(false);
        palm.SetActive(false);
    }
    public void Apple()
    {
        trans[2].anchoredPosition = Vector3.zero;
        banana.SetActive(false);
        apple.SetActive(true);
        bonsai.SetActive(false);
        pine.SetActive(false);
        palm.SetActive(false);
    }
    public void Pine()
    {
        trans[2].anchoredPosition = Vector3.zero;
        banana.SetActive(false);
        apple.SetActive(false);
        bonsai.SetActive(false);
        pine.SetActive(true);
        palm.SetActive(false);
    }
    public void Palm()
    {
        trans[2].anchoredPosition = Vector3.zero;
        banana.SetActive(false);
        apple.SetActive(false);
        bonsai.SetActive(false);
        pine.SetActive(false);
        palm.SetActive(true);
    }
    public void Bonsai()
    {
        trans[2].anchoredPosition = Vector3.zero;
        banana.SetActive(false);
        apple.SetActive(false);
        bonsai.SetActive(true);
        pine.SetActive(false);
        palm.SetActive(false);
    }
    public void Airplane()
    {
        trans[4].anchoredPosition = Vector3.zero;
        airplane1.SetActive(true);
        heli.SetActive(false);
        drone.SetActive(false);
        rocket.SetActive(false);
        fj.SetActive(false);
    }
    public void FJ()
    {
        trans[4].anchoredPosition = Vector3.zero;
        airplane1.SetActive(false);
        heli.SetActive(false);
        drone.SetActive(false);
        rocket.SetActive(false);
        fj.SetActive(true);
    }
    public void Rocket()
    {
        trans[4].anchoredPosition = Vector3.zero;
        airplane1.SetActive(false);
        heli.SetActive(false);
        drone.SetActive(false);
        rocket.SetActive(true);
        fj.SetActive(false);
    }
    public void Helicopter()
    {
        trans[4].anchoredPosition = Vector3.zero;
        airplane1.SetActive(false);
        heli.SetActive(true);
        drone.SetActive(false);
        rocket.SetActive(false);
        fj.SetActive(false);
    }

    public void Drone()
    {
        trans[4].anchoredPosition = Vector3.zero;
        airplane1.SetActive(false);
        heli.SetActive(false);
        drone.SetActive(true);
        rocket.SetActive(false);
        fj.SetActive(false);
    }

    public void Parrot()
    {
        trans[3].anchoredPosition = Vector3.zero;
        parrot.SetActive(true);
        sparrow.SetActive(false);
        penguin.SetActive(false);
        rooster.SetActive(false);
        turkey.SetActive(false);
    }
    public void Sparrow()
    {
        trans[3].anchoredPosition = Vector3.zero;
        parrot.SetActive(false);
        sparrow.SetActive(true);
        penguin.SetActive(false);
        rooster.SetActive(false);
        turkey.SetActive(false);
    }
    public void Penguin()
    {
        trans[3].anchoredPosition = Vector3.zero;
        parrot.SetActive(false);
        sparrow.SetActive(false);
        penguin.SetActive(true);
        rooster.SetActive(false);
        turkey.SetActive(false);
    }
    public void Rooster()
    {
        trans[3].anchoredPosition = Vector3.zero;
        parrot.SetActive(false);
        sparrow.SetActive(false);
        penguin.SetActive(false);
        rooster.SetActive(true);
        turkey.SetActive(false);
    }
    public void Turkey()
    {
        trans[3].anchoredPosition = Vector3.zero;
        parrot.SetActive(false);
        sparrow.SetActive(false);
        penguin.SetActive(false);
        rooster.SetActive(false);
        turkey.SetActive(true);
    }

    public void LionAR()
    {
       
    }

}
