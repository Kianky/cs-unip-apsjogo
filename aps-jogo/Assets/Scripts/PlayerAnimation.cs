using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    PlayerScript player;
    [SerializeField] SpriteRenderer playerSprite;
    [SerializeField] Sprite[] spritesCima, spritesBaixo, spritesEsquerda, spritesDireita;
    [SerializeField] Sprite[] andandoCima, andandoBaixo, andandoEsquerda, andandoDireita;
    int index;
    float timer, maxTimer;
    void Start()
    {
        player = GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        AnimarPlayer();
    }

    void AnimarPlayer()
    {
        if (player.move.estaParado)
        {
            maxTimer = 1f;
            switch (player.move.GetDirecao)
            {
                case Direcao.CIMA:
                    playerSprite.sprite = spritesCima[index];
                    break;
                case Direcao.BAIXO:
                    playerSprite.sprite = spritesBaixo[index];
                    break;
                case Direcao.ESQUERDA:
                    playerSprite.sprite = spritesEsquerda[index];
                    break;
                case Direcao.DIREITA:
                    playerSprite.sprite = spritesDireita[index];
                    break;
            }
        }
        else
        {
            maxTimer = 0.12f / player.move.GetVelocidade;
            switch (player.move.GetDirecao)
            {
                case Direcao.CIMA:
                    playerSprite.sprite = andandoCima[index];
                    break;
                case Direcao.BAIXO:
                    playerSprite.sprite = andandoBaixo[index];
                    break;
                case Direcao.ESQUERDA:
                    playerSprite.sprite = andandoEsquerda[index];
                    break;
                case Direcao.DIREITA:
                    playerSprite.sprite = andandoDireita[index];
                    break;
            }
        }
        timer += 1 * Time.deltaTime;
        if(timer >= maxTimer)
        {
            timer = 0;
            if (index < 5)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
    }
}
