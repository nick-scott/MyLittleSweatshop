using UnityEngine;

public class PlayerResource : MonoBehaviour {

	public long StartingResource = 400;
	private TextMesh _textMesh;
	private long playerResource = 0;


	// Use this for initialization
	void Start ()
	{
		playerResource = StartingResource;
		_textMesh = GetComponent<TextMesh>();
		_textMesh.text = playerResource + "";
	}
	
	// Update is called once per frame
	void Update ()
	{
		_textMesh.text = playerResource + "";
	}

	public void increaseResouce(int increase)
	{
		playerResource += increase;
	}

	public long getResource()
	{
		return playerResource;
	}
}
