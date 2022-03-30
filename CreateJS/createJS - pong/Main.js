/* define variables for all graphic objects */

var canvas; //linked to the canvas in index.html
var stage; // is, unsurprisingly, the stage

//graphics
//[background]
var bg; //background graphic

//[title view]
var main; //main background
var startB; //Start button in main menu
var creditsB; //Credits button in main menu

//[credits]
var credits; //Credits screen

//[game view]
var player; //player paddle graphic
var ball; //ball graphic
var cpu; //CPU paddle
var win; //winning popup
var lose; //losing popup

//[score]
var playerScore; //main player score
var cpuScore; //CPU score
var cpuSpeed=6; //speed of CPU paddle - faster it goes, the harder the game

//[speed variables]
var xSpeed = 5;
var ySpeed = 5;

//add variable for linking to the ticker object (runs code every fraction of a second)
var tkr = new Object;

//preloader, using PreloadJS methods
var preloader; //contains PreloadJS object
var manifest; //holds list of files to be loaded
var totalLoaded = 0; //number of files loaded

//TitleView holds several graphics in order to display them together
var TitleView = new createjs.Container();



/* *** Main() function *** */

function Main()
{
	/* link PongStage Canvas object from index.html to canvas variable, then create Stage object from the canvas */
	canvas = document.getElementById('PongStage');
  	stage = new createjs.Stage(canvas);
	
	/* allow mouse movements and clicks to be detected */
	stage.mouseEventsEnabled = true;
	
	/* for the old browsers that don't support SoundJS, use Flash (ewwwwwwww) */
  	createjs.FlashPlugin.BASE_PATH = "assets/";
	if (!createjs.SoundJS.checkPlugin(true))
	{
		alert("Error!");
		return;
	}
	
	/* array of files that need loading */
	manifest = [{src:"bg.png", id:"bg"},
					{src:"main.png", id:"main"},
					{src:"startB.png", id:"startB"},
					{src:"creditsB.png", id:"creditsB"},
					{src:"credits.png", id:"credits"},
					{src:"paddle.png", id:"cpu"},
					{src:"paddle.png", id:"player"},
					{src:"ball.png", id:"ball"},
					{src:"win.png", id:"win"},
					{src:"lose.png", id:"lose"},
					{src:"playerScore.mp3|playerScore.ogg", id:"playerScore"},
					{src:"enemyScore.mp3|enemyScore.ogg", id:"enemyScore"},
					{src:"hit.mp3|hit.ogg", id:"hit"},
					{src:"wall.mp3|wall.ogg", id:"wall"}];
				
	/* configure the preloader object using PreloadJS */
	//create new PreloadJS object
	preloader = new createjs.PreloadJS();
	//put it in the preloader variable
	preloader.installPlugin(createjs.SoundJS);
	//assign a method to each event
	preloader.onProgress = handleProgress;
	preloader.onComplete = handleComplete;
	preloader.onFileLoad = handleFileLoad;
	//use preloader to load the manifest
	preloader.loadManifest(manifest);
	
	//add Ticker object to the stage and set frame rate
	createjs.Ticker.setFPS(30);
	createjs.Ticker.addListener(stage);		
}


/* *** Preloader functions *** */
function handleProgress(event)
{
	//use event.loaded to get the loading percentage - for progress bar, etc.
}

function handleComplete(event)
{
	//when finished loading ALL files
}

function handleFileLoad(event)
{
	//when individual files finish loading 
	switch(event.type)
	{
		//if image loaded then create bitmap and stick in a variable before calling handleLoadComplete
		case createjs.PreloadJS.IMAGE:
		var img = new Image();
		img.src = event.src;
		img.onload = handleLoadComplete;
		window[event.id] = new createjs.Bitmap(img);
		break;
		
		//if sound loaded then just call handleLoadComplete
		case createjs.PreloadJS.SOUND:
		handleLoadComplete();
		break;
	}
}

function handleLoadComplete(event)
{
	//number of assets loaded increases
	totalLoaded++;
	//if number of items in manifest is same as number of loaded assets then head to the Main Menu screen
	if(manifest.length==totalLoaded)
	{
		addTitleView();
	}
}


/* *** Main Menu *** */
function addTitleView()
{
	//console.log("Add title view");
	
	//place images of background, Start and Credit buttons on the stage
	startB.x = 240 - 41.5;
	startB.y = 160;
	startB.name = 'startB';
	creditsB.x = 241 - 42;
	creditsB.y = 200;
	TitleView.addChild(main, startB, creditsB);
	stage.addChild(bg, TitleView);
	stage.update();
	
	//then link onPress event handlers
	startB.onPress = tweenTitleView;
	creditsB.onPress = showCredits;
}

/* functions to display and remove credits screen and tweenTitleView which starts the game */
function showCredits() //guess what this does...
{
	credits.x = 480;
	stage.addChild(credits);
	stage.update();
	createjs.Tween.get(credits).to({x:0}, 300);
	credits.onPress = hideCredits;
}

function hideCredits(e) //any idea what this function might do?
{
	createjs.Tween.get(credits).to({x:480}, 300).call(rmvCredits);
}

function rmvCredits() //another consonant please Carol...
{
	stage.removeChild(credits);
}

function tweenTitleView() //let's get ready to rumble!
{
	createjs.Tween.get(TitleView).to({y:-320}, 300).call(addGameView);
}


/* *** Game Code - finally!! *** */
function addGameView()
{
	//exterminate the menu and credits screen
	stage.removeChild(TitleView);
	TitleView = null;
	credits = null;
	
	//position players and ball
	player.x = 2;
	player.y = 160 - 37.5;
	cpu.x = 480 - 25;
	cpu.y = 160 - 37.5;
	ball.x = 240 - 15;
	ball.y = 160 - 15;
	
	//positions the starting scores
	playerScore = new createjs.Text('0', 'bold 20px Arial', '#fee900');
	playerScore.x = 211;
	playerScore.y = 20;
	cpuScore = new createjs.Text('0', 'bold 20px Arial', '#fee900');
	cpuScore.x = 262;
	cpuScore.y = 20;
	
	//add positioned elements to the screen
	stage.addChild(playerScore, cpuScore, player, cpu, ball);
	stage.update();
	
	//start listening for the user to click on the background image
	bg.onPress = startGame;
}

function startGame(e)
{
	bg.onPress = null;
	stage.onMouseMove = movePaddle;
	createjs.Ticker.addListener(tkr, false);
	tkr.tick = update;
}

function movePaddle(e)
{
	//place the user's paddle at the mouse's y-coordinate
	player.y = e.stageY;
}

function reset()
{
	//similar to addGameView but graphics are already on the screen
	ball.x = 240 - 15;
	ball.y = 160 - 15;
	player.y = 160 - 37.5;
	cpu.y = 160 - 37.5;
	stage.onMouseMove = null;
	createjs.Ticker.removeListener(tkr);
	bg.onPress = startGame;
}


/* *** Into the loop *** */
function update ()
{
	//moving the ball according to its x and y speed values
	ball.x = ball.x + xSpeed;
	ball.y = ball.y + ySpeed;
	
	//making the CPU's paddle follow the ball by comparing the central location of the paddle with the location of the ball
	if((cpu.y+32) < (ball.y-14))
	{
		cpu.y = cpu.y + cpuSpeed;
	}
	else if((cpu.y+32) > (ball.y+14))
	{
		cpu.y = cpu.y - cpuSpeed;
	}
	
	//if the ball hits the top or bottom border then change direction and play Wall Hit sound
	if((ball.y) < 0) //top border
	{
		ySpeed = -ySpeed;
		createjs.SoundJS.play('wall');
	};
	
	if((ball.y + (30)) > 320) //bottom border
	{
		ySpeed = -ySpeed;
		createjs.SoundJS.play('wall');
	};
	
	//CPU score
	if((ball.x) < 0)
	{
		xSpeed = -xSpeed;
		//increase score
		cpuScore.text = parseInt(cpuScore.text + 1);
		//reset the locations
		reset();
		//play the enemy's scoring sound
		createjs.SoundJS.play('enemyScore');
	}
	
	//Player score
	if((ball.x + (30)) > 480)
	{
		xSpeed = -xSpeed;
		// increase score
		playerScore.text = parseInt(playerScore.text + 1);
		// reset the locations
		reset();
		//play the player's scoring sound
		createjs.SoundJS.play('playerScore');
	}
	
	/* if the ball hits the paddle, it changes direction and a sound is played */
	//CPU collision
	if(ball.x + 30 > cpu.x && ball.x + 30 < cpu.x + 22 && ball.y >= cpu.y && ball.y < cpu.y + 75)
	{
		xSpeed *= -1;
		createjs.SoundJS.play('hit');
	}
	
	//Player collision
	if(ball.x <= player.x + 22 && ball.x > player.x && ball.y >= player.y && ball.y < player.y + 75)
	{
		xSpeed *= -1;
		createjs.SoundJS.play('hit');
	}
	
	//if a paddle goes out of bounds, it gets put back in bounds
	if(player.y >= 249)
	{
		player.y = 249;
	}
	
	/* are you a winner? */
	if(playerScore.text == '10')
	{
		alert('win');
	}
	
	/* or a loser? */
	if(cpuScore.text == '10')
	{
		alert('lose');
	}
	
}

function alert(e)
{
	createjs.Ticker.removeListener(tkr);
	stage.onMouseMove = null;
	bg.onPress = null;
	if(e == 'win')
	{
		win.x = 140;
		win.y = -90;
		stage.addChild(win);
		createjs.Tween.get(win).to({y: 115}, 300);
	}
	else
	{
		lose.x = 140;
		lose.y = -90;
		stage.addChild(lose);
		createjs.Tween.get(lose).to({y: 115}, 300);
	}
}

// end of code