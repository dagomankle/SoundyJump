#pragma strict

function Start () {
	
}

function Update () {
	
}
function OnGUI ()
{
   GUI.color = new Color(1,1,1,0.0f);
 if( GUI.Button(new Rect(130,25,50,55),""))
   {
	 Application.LoadLevel("MenuPrincipal");
   }
  GUI.color = new Color(1,1,1,0.7f);
  if( GUI.Button(new Rect(500,110,85,25),"") )
   {
	 Application.LoadLevel("EscenaJuego");
   }
    if( GUI.Button(new Rect(500,163,85,25),"") )
   {
	 Application.LoadLevel("MenuPago");
   }

}