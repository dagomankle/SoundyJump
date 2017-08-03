#pragma strict

function Start () {
	
}

function Update () {
	
}

function OnGUI ()
{
   GUI.color = new Color(1,1,1,0.7f);
 if( GUI.Button(new Rect(273,118,178,55),""))
   {
	 Application.LoadLevel("MenuPrincipal");
   }
  if( GUI.Button(new Rect(273,185,178,55),"") )
   {
	 Application.LoadLevel("MenuPrincipal");
   }
    if( GUI.Button(new Rect(273,265,178,55),"") )
   {
	 Application.LoadLevel("MenuPrincipal");
   }

}