<?php
/*
* Code by Black 
* E-mail: 3000Lane@gmail.com
*/
	require('./data/config.php');
	require('./data/functions.php');
	$setting_data = getSettings();
	$news_array = getNews($setting_data);
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta http-equiv="content-type" content="text/html;charset=UTF-8" />
		<meta http-equiv="cache-control" content="no-cache" />
		
		<style type="text/css">
			body {
				background-image: url('./data/img/bg.jpg');
				background-repeat: no-repeat;
				background-color:#000000;
				color: #A99877;
				font: normal 13px/1.5 Arial, sans-serif;
			}
				
			.header{
				position:absolute;
				left:0px;
				top:3px;
			}

			.b_forum {
				display:inline-block;
				width: 36px;
				height: 36px;
				background-image: url('./data/img/b-forum.png');
				position:absolute;
				left:5px;
				cursor: pointer;
			}
				
			.b_rpw {
				display: block;
				width: 35px;
				height: 36px;
				background-image: url('./data/img/b-rpw.png');
				position:absolute;
				left:45px;
				cursor: pointer;
			}
				
			.b_settings {
				display: block;
				width: 36px;
				height: 36px;
				background-image: url('./data/img/b-setting.png');
				position:absolute;
				left:85px;
			}
				
			.b_status {
				display: block;
				width: 36px;
				height: 36px;
				background-image: url('./data/img/server-on.png');
				position:absolute;
				left:320px;
			}
				
			.news{
				position:absolute;
				left:0px;
				top:46px;
			}
			
			.news > div {
				cursor: pointer;
			}
			
			.news > div:hover {
				font-weight: bold;
				font-size: 14px;
			}

			.news_topic_c0{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_0.jpg');
				color: #F3E6D0;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}
			.news_topic_c1{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_1.jpg');
				color: #7979D4;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}	
			.news_topic_c2{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_2.jpg');
				color: #F8CC35;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}	
			.news_topic_c3{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_3.jpg');
				color: #BF642F;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}	
			.news_topic_c4{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_4.jpg');
				color: #990a98;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}	
			.news_topic_c5{
				display: block;
				width: 360px;
				height: 43px;
				background-image: url('./data/img/news/topic_5.jpg');
				color: #8BD442;
				font: 12px "Palatino Linotype", "Times", serif;
				line-height: 37px;
				text-align: center;
				overflow: hidden;
				white-space: nowrap;
				text-overflow: ellipsis;
			}
		</style>
		<script type="text/javascript">
			function openURL(url){
				    window.location = url;
			}
		</script>
		
		<title>World of Warcraft News Launcher</title>
	</head>
<body>
	<div class="header">
		<div class="b_forum" onclick="openURL('<? echo $setting_data["f_url"]; ?>')"></div>
		<!--<div class="b_status"></div>-->
		<div class="b_rpw" onclick="openURL('<? echo $setting_data["server_link"]; ?>')"></div>
	</div>
	<div class="news">
		<?php
		foreach($news_array as $news){
			echo "<div onclick='openURL(\"".$news['link']."\")' class='news_topic_c".$news['type']."'>".$news['text']."</div>";
		}
		?>
	</div>
</body>
</html>