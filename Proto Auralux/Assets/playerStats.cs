using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    [SerializeField]
    private Text _energyText;

    [SerializeField]
    public List<planetScript> _planets;

    private float _energyPerSecond = 0;

    private float _currentEnergy = 0;

    [SerializeField]
    private float _energyPerTroop;

    [SerializeField]
    private Button _spawnTroopButton;

    // Start is called before the first frame update
    void Start()
    {
        CalcEnergyPerSecond();
        _spawnTroopButton.onClick.AddListener(SpawnTroop);
    }

    // Update is called once per frame
    void Update()
    {
        _currentEnergy += _energyPerSecond * Time.deltaTime;
        _energyText.text = "Energy: " + Mathf.Round(_currentEnergy).ToString();
    }

    private void CalcEnergyPerSecond()
    {
        _energyPerSecond = 0;

        foreach (var planet in _planets)
        {
            if (planet.planetState == 0)
            {
                _energyPerSecond += planet.GetEnergy();
            }
        }
    }

    public void SetEnergy(float energy)
    {
        _currentEnergy += energy;
    }

    private void SpawnTroop()
    {
        
        if (_currentEnergy - _energyPerTroop < 0)
        {
            return;
        }
        _currentEnergy -= _energyPerTroop;
        foreach (var planet in _planets)
        {
            if (planet.planetState == 0)
            {
                if (true)
                {

                }
                planet.SpawnTroop();
            }
        }
    }
}
