using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] VariableJoystick joystick;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    public TextMeshProUGUI skortx;
    public int skorPlayer=0;
    Vector2 direction;

    public Vector2 Direction { get { return direction; } }

    private void Start()
    {
        rb.gravityScale = 0;
        if( PlayerPrefs.HasKey("skor")){
            skorPlayer = PlayerPrefs.GetInt("skor");
            UpScore();
            //load posisi
            transform.position= new Vector3( PlayerPrefs.GetFloat("posx"),PlayerPrefs.GetFloat("posy"),PlayerPrefs.GetFloat("posz"));
        }
    }
    public void SaveGame(){
         //save posisi
             skorPlayer+=10;
            UpScore();
        
         PlayerPrefs.SetFloat("posx",transform.position.x);
          PlayerPrefs.SetFloat("posy",transform.position.y);
           PlayerPrefs.SetFloat("posz",transform.position.z);
    }
    void UpScore(){
        if(skortx != null){
          skortx.text= "Skor="+skorPlayer;
         PlayerPrefs.SetInt("skor",skorPlayer);
        }
   
    }
    private void Update()
    {
        
        var horizontal = joystick.Horizontal;
        var vertical = joystick.Vertical;
        direction = new Vector2(horizontal, vertical);
        direction.Normalize();
        if (direction.magnitude > 0.1f)
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
        }
        animator.SetFloat("Speed", direction.magnitude);
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

}
