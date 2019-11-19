using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork.Common;
using TMPro;

public class GameManager : MonoBehaviour
{
    //On enter
    [SerializeField]
    private string GameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;


    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private TMP_Text ScoreText;

    [SerializeField]
    private TMP_Text LocationText;

    [SerializeField]
    private TMP_Text MovesText;

    private Game Game 
    { 
        get; 
        set; 
    }
    // Start is called before the first frame update
    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFileAssetName);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);

        ScoreText.text = $"Score: {Game.Player.Score}";
        MovesText.text = $"Moves: {Game.Player.ZorkMoves}";
        LocationText.text = $"Location: {Game.Player.Location}";

        //for (int i = 0; i < 20; i++)
        //{
        //   Game.Output.WriteLine(i);
        //}
        //Game.Output.WriteLine("Welcome to Zork!");
    }

    void Start()
    {
        Game.Output.WriteLine("Welcome to Zork!");
        Game.CommandManager.PerformCommand(Game, "LOOK");
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($">{InputService.InputField.text}");
                InputService.ProcessInput();
                ScoreText.text = $"Score: {Game.Player.Score}";
                MovesText.text = $"Moves: {Game.Player.ZorkMoves}";
                LocationText.text = $"Location: {Game.Player.Location}";

            }
            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();

        }
        
    }
}
