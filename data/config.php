<?php
/*
* Code by KroniX 
* E-mail: KroniX@rp-welten.net
* Website: http://rp-welten.net
*/
	// Hier müsst ihr eure Datenbank daten angeben
	$db = array(
		'host'		=> 'localhost',					// Datenbank Link std. "localhost"
		'port'		=> '',							// Datenbank Port std. "3306"
		'user'		=> 'root',						// Datenbank Benutzer std. "root"
		'password'	=> 'root',						// Datenbank Passwort
		'db'		=> 'forum',						// Datenbank Name
	);
	$topic_table = 'forum_topics';					// Name der Thementabelle, phpbb3 std. "phpbb3_topics"
	
	$website_url = 'http://rp-welten.net';			// Link zu deiner eigenen Website
	$rpw_id = '0';									// Falls du ein RP-Welten ID besitzt, kannst du diese hier eintragen.
	$news_forum_id = '34';							// Die ID des Forums aus welchem die News ausgelesen werden sollen.
	
	
	/*Color Hash
	*Der "Color Hash" ist ein Farbaufbau um die verschiedenen Themenarten darzustellen.
	*
	*Zahlen: Es können die Zahlen 0 bis 5 verwendet werden und jeder dieser Zahlen
	*stellt eine andere Farbe da. Eine dafür entsprechende Liste finden sie hier:
	****Zahlen****
	* 0 => Grau  *
	* 1 => Blau  *
	* 2 => Gold  *
	* 3 => Orange*
	* 4 => Lila  *
	* 5 => Grün  *
	**************
	*
	*Reinfolge: Die Reinfolge der Zahlen ist auch wichtig da diese die verschiedenen Themenarten ausgibt.
	****************Reinfolge*****************
	* Erste Zahl => Normale Nachrichten      *
	* Zweite Zahl => Wichtige Nachrichten    *
	* Dritte Zahl => Bekanntmachungen        *
	* Vierte Zahl => Globale Bekanntmachungen *
	******************************************
	*/
	$color_hash = '0|5|3|2';
	
	$mysql_link = mysql_connect($db['host'].$db['port'], $db['user'], $db['password']);
	if(!$mysql_link) die('Error: ' . mysql_error());
	else unset($db['password']);
	mysql_select_db($db['db'], $mysql_link);
?>