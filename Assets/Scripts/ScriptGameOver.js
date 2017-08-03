#pragma strict

function Start () {
	
}

function Update () {
	
}
function OnGUI ()
{
   GUI.color = new Color(1,1,1,0.0f);
 if( GUI.Button(new Rect(235,150,282,72),""))
   {
	 Application.LoadLevel("EscenaJuego");
   }
  if( GUI.Button(new Rect(235,237,282,72),"") )
   {
	 Application.LoadLevel("MenuPrincipal");
   }

}

