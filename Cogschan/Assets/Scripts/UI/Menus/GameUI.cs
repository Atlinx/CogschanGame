﻿using UnityEngine;

public class GameUI : MonoBehaviour
{
    [Header("External Dependencies")]
    [SerializeField] private EntityServiceLocator _services;
    [SerializeField] private PlayerCameraController _playerCameraController;

    [Header("Local Dependencies")]
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private AmmoCounterDisplay _ammoCounterDisplay;
    [SerializeField] private InteractionMessage _interactionMessage;
    [SerializeField] private Transform _targetReticle;

    private void Start()
    {
        _playerCameraController.Construct(_targetReticle);
        _healthbar.Construct(_services);
        _ammoCounterDisplay.Construct(_services);
        _interactionMessage.Construct(_services);
    }
}