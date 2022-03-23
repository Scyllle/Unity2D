using UnityEngine;

public class Pular : MonoBehaviour

{

public int Forca = 30;

void Update()

{

if (Input.GetKey(KeyCode.Space))

{

GetComponent<Animator>().SetTrigger("Pulo");

GetComponent<Rigidbody2D>().AddForce(

new Vector2(0, Forca));

}

}

}