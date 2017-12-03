using UnityEngine;
using System.Collections;

public class MapTile : MonoBehaviour
{
//	MAP_TILE_TYPE type = MAP_TILE_LINE;

	void Start()
	{
	}

	void Update()
	{
		if ( GameManager.gameMgr.m_isPaused )
			return;

		// do things...
	}
};
