using UnityEngine;
using System.Collections;

public class MapManager : MonoBehaviour
{
	public static MapManager mapMgr;

	public uint width = 0;
	public uint height = 0;

	public GameObject lineTile;
	public GameObject angleTile;
	public GameObject halfCrossTile;
	public GameObject crossTile;

	public GameObject[] defaultMapTiles;

	private const uint defWidth = 10;
	private const uint defHeight = 10;


	private void SetDefaults()
	{
		if ( width <= 0 )
			width = defWidth;

		if ( height <= 0 )
			height = defHeight;
	}

	void Start()
	{
		if ( mapMgr == null )
			mapMgr = this.gameObject.GetComponent<MapManager>();

		Debug.Log ("MapManager start");
		SetDefaults();
	}

	public GameObject[] GetMap()
	{
		return defaultMapTiles;
	}

	void Update()
	{
		if ( GameManager.gameMgr.m_isPaused )
			return;

		// do things...
	}
};
