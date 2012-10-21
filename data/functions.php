<?php
/*
* Code by KroniX 
* E-mail: KroniX@rp-welten.net
* Website: http://rp-welten.net
*/

function getSettings(){
	global $website_url, $color_hash, $rpw_id;
	
	$settings = Array(
		'f_url'			=> $website_url,
		'server_link'	=> 'http://rp-welten.net/server?id=' . $rpw_id,
		'color'			=> explode("|", $color_hash),
	);
	return $settings;
}

function getNews($setting_data){
	global $mysql_link, $topic_table, $news_forum_id;
	$news = Array();
	
	$db_sql = "SELECT topic_id, topic_title, topic_type FROM " . $topic_table . " WHERE `forum_id` = " . $news_forum_id . " ORDER BY topic_id desc LIMIT 10";
	$db_news = mysql_query($db_sql, $mysql_link);
	if(!$db_news) die('Error: ' . mysql_error());

	while($row = mysql_fetch_assoc($db_news)){
		$type = $row['topic_type'];
		
		switch ($type) {
			case 0:
				$type = $setting_data['color'][0];
			break;
			case 1:
				$type = $setting_data['color'][1];
			break;
			case 2:
				$type = $setting_data['color'][2];
			break;
			case 3:
				$type = $setting_data['color'][3];
			break;
		}
		array_push($news, Array(
			'link'	=> htmlspecialchars($setting_data["f_url"]. "/viewtopic?f=" . $news_forum_id . "&t=" . $row['topic_id']),
			'type'	=> $type,
			'text'	=> htmlentities($row['topic_title']),
		));
	}
	
	mysql_close($mysql_link);
	return $news;
}
?>