using UnityEngine;
using UnityEngine.UI;

public class LanternScriptLevel2 : MonoBehaviour
{
    public GameObject Lantern;
    public SpriteRenderer spriteRenderer;
    public new Rigidbody2D rigidbody;
    private Scrollbar scrollbar;
    public Sprite fullSprite;
    public Animator animator;
    public AudioSource lanternAudioSource;
    public float yDeadZoneMax = 5.4f;
    public float yDeadZoneMin = -6f;
    private AudioSource scrollbarSound;

    void Awake()
    {
        animator.enabled = false;
        scrollbarSound = GameObject.Find("Scrollbar").GetComponent<AudioSource>(); ;
        scrollbar = GameObject.Find("Scrollbar").GetComponent<Scrollbar>();
}
    void Start()
    {
        scrollbarSound.enabled = false;
        lanternAudioSource.enabled = false;
    }

    void Update()
    {
        if (Lantern.transform.position.y >= yDeadZoneMax)
        {
            if(spriteRenderer.sprite.name == "Lantern-mid")
            {
                scrollbar.size -= 0.05f;
            }
            else if (spriteRenderer.sprite.name == "Lantern-full")
            {
                scrollbar.size += 0.05f;
                scrollbarSound.enabled = true;
            }

            Destroy(Lantern);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Particle")
        {
            spriteRenderer.sprite = fullSprite;
            lanternAudioSource.enabled = true;
            rigidbody.gravityScale = 0f;
            animator.enabled = true;
            rigidbody.gravityScale = -0.1f;
        }
    }

}
