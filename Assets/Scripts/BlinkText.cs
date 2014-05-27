using UnityEngine;
using System.Collections;


public class BlinkText : MonoBehaviour	{

	public float TextBlinkTime;
	private Color _textColorON;
	private Color _textColorOFF;
	private bool _fadingIn;
	private float _timer;
	private float _tmpDeltaTime;
	
	void Start ()
	{
		#if UNITY_EDITOR
		// Security check only in editor mode
		if(guiTexture == null)
		{
			Debug.LogError("The script Blink must be attached to a GUIText Game Object!");
			gameObject.SetActive(false); // Disable the Game Object
			return;
		}
		#endif	
		
		// Create the 2 colors used to compute the interpolation
		var textColor = guiTexture.color;
		_textColorON = new Color(textColor.r, textColor.g, textColor.b, 1);
		_textColorOFF = new Color(textColor.r, textColor.g, textColor.b, 0);
		
		_fadingIn = false; // Start from visible to invisible (fade out)
		_timer = Time.time; // Start the timer
	}
	
	void Update ()
	{
		#if UNITY_EDITOR
		// In editor, retreive the last value of the text color to make possible
		// to change it during play mode.
		var textColor = guiTexture.color;
		_textColorON = new Color(textColor.r, textColor.g, textColor.b, 1);
		_textColorOFF = new Color(textColor.r, textColor.g, textColor.b, 0);
		#endif	
		
		// Compute the proportional animation time between 0 and 1 for the Lerp below
		_tmpDeltaTime = (Time.time - _timer) / TextBlinkTime;
		
		// Perform the proper color interpolation
		if(_fadingIn)
		{
			// From invisible to visible
			guiTexture.color = Color.Lerp(_textColorOFF, _textColorON, _tmpDeltaTime);
		}
		else
		{
			// From visible to invisible
			guiTexture.color = Color.Lerp(_textColorON, _textColorOFF, _tmpDeltaTime);
		}
		
		if(_tmpDeltaTime > 1)
		{
			// Reverse the fade when the Lerp is complete
			_fadingIn = !_fadingIn; 
			_timer = Time.time;
		}
	}
}