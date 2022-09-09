using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    public Image changingPanel;

    //hat
    public SpriteRenderer hat;

    //hair
    public SpriteRenderer mainHair;
    public SpriteRenderer ponytail;
    public SpriteRenderer sideHair;
    public SpriteRenderer frontHair;

    //body
    public SpriteRenderer torso;

    //arms
    public SpriteRenderer armFrontUp;
    public SpriteRenderer armFrontDown;
    public SpriteRenderer armBacktUp;
    public SpriteRenderer armBackDown;

    //pants
    public SpriteRenderer pantsFrontUp;
    public SpriteRenderer pantsFrontDown;
    public SpriteRenderer pantsBacktUp;
    public SpriteRenderer pantsBackDown;

    //shoes
    public SpriteRenderer shoeFront;
    public SpriteRenderer shoeBack;

    //lists

    public List<Sprite> hatOptions = new List<Sprite>();

    public List<Sprite> mainHairOptions = new List<Sprite>();
    public List<Sprite> ponytailOptions = new List<Sprite>();
    public List<Sprite> sideHairOptions = new List<Sprite>();
    public List<Sprite> frontHairOptions = new List<Sprite>();

    public List<Sprite> torsoOptions = new List<Sprite>();

    public List<Sprite> armFrontUpOptions = new List<Sprite>();
    public List<Sprite> armFrontDownOptions = new List<Sprite>();
    public List<Sprite> armBacktUpOptions = new List<Sprite>();
    public List<Sprite> armBackDownOptions = new List<Sprite>();

    public List<Sprite> pantsFrontUpOptions = new List<Sprite>();
    public List<Sprite> pantsFrontDownOptions = new List<Sprite>();
    public List<Sprite> pantsBacktUpOptions = new List<Sprite>();
    public List<Sprite> pantsBackDownOptions = new List<Sprite>();

    public List<Sprite> shoeFrontOptions = new List<Sprite>();
    public List<Sprite> shoeBackOptions = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateSection(int index)
    {
        changingPanel.gameObject.SetActive(true);
    }

    public void SelectHatOption(int index)
    {
        hat.sprite = hatOptions[index];
    }

    public void SelectHairOption(int index)
    {
        mainHair.sprite = mainHairOptions[index];
        ponytail.sprite = ponytailOptions[index];
        sideHair.sprite = sideHairOptions[index];
        frontHair.sprite = frontHairOptions[index];
    }

    public void SelectTorsoOption(int index)
    {
        torso.sprite = torsoOptions[index];        
    }

    public void SelectArmsOption(int index)
    {
        armFrontUp.sprite = armFrontUpOptions[index];
        armFrontDown.sprite = armFrontDownOptions[index];
        armBacktUp.sprite = armBacktUpOptions[index];
        armBackDown.sprite = armBackDownOptions[index];
    }

    public void SelectLegsOption(int index)
    {
        pantsFrontUp.sprite = pantsFrontUpOptions[index];
        pantsFrontDown.sprite = pantsFrontDownOptions[index];
        pantsBacktUp.sprite = pantsBacktUpOptions[index];
        pantsBackDown.sprite = pantsBackDownOptions[index];
    }

    public void SelectShoesOption(int index)
    {
        shoeFront.sprite = shoeFrontOptions[index];
        shoeBack.sprite = shoeBackOptions[index];
    }
}
