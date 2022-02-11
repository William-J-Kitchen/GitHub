function displayType(game) {
    var gameType = game.getAttribute("data-game_type");
    alert(gameType + " is a great " + game.innerHTML +" game!");
}