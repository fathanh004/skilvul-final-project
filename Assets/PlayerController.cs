using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    [SerializeField] float speed;
    [SerializeField] VariableJoystick joystick;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] GameObject uiInventory;
    [SerializeField] Button btnInteraksi;
    public TextMeshProUGUI skortx;
    public AudioSource footstep;
    public int skorPlayer = 0;
    public bool isFindInteractable = false;
    Vector2 direction;
    public IteminGame itemInteraksi;
    public Vector2 Direction { get { return direction; } }

    private void Start()
    {
        instance = this;
        btnInteraksi.interactable = false;
        rb.gravityScale = 0;
        if (PlayerPrefs.HasKey("skor"))
        {
            skorPlayer = PlayerPrefs.GetInt("skor");
            UpScore();
            //load posisi
            transform.position = new Vector3(PlayerPrefs.GetFloat("posx"), PlayerPrefs.GetFloat("posy"), PlayerPrefs.GetFloat("posz"));
        }
    }

    public void OpenInventory()
    {

        uiInventory.transform.localScale = Vector3.zero;
        uiInventory.SetActive(true);
        LeanTween.scale(uiInventory, Vector3.one, 0.2f).setEaseInOutBounce();
    }
    public void CloseInventory()
    {


        LeanTween.scale(uiInventory, Vector3.zero, 0.2f);
    }

    public void ToggleInteractButton(bool isInteractable, IteminGame item)
    {
        itemInteraksi = item;
        btnInteraksi.interactable = isInteractable;
    }

    public void KlikButtonInteraksi()
    {

        SistemInventori.instance.TambahItem(itemInteraksi.itemCollect);
        itemInteraksi.gameObject.SetActive(false);
    }
    public void SaveGame()
    {
        //save posisi
        skorPlayer += 10;
        UpScore();

        PlayerPrefs.SetFloat("posx", transform.position.x);
        PlayerPrefs.SetFloat("posy", transform.position.y);
        PlayerPrefs.SetFloat("posz", transform.position.z);
    }
    void UpScore()
    {
        if (skortx != null)
        {
            skortx.text = "Skor=" + skorPlayer;
            PlayerPrefs.SetInt("skor", skorPlayer);
        }

    }
    bool isFootstepPlaying = false;
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

        if (direction.magnitude > 0.1f && !isFootstepPlaying) 
        {
            footstep.Play();
            isFootstepPlaying = true;
        } else if (direction.magnitude < 0.1f && isFootstepPlaying)
        {
            footstep.Stop();
            isFootstepPlaying = false;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

}
