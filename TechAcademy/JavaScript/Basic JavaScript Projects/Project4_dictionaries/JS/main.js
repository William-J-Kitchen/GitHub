function Dictionary() {
    var Game = { //creates the Game dictionary
        Name: "Chrono Trigger",
        Genre: "RPG",
        Origin: "Japan",
        Year: 1995
    };
    delete Game.Name; //deletes the name key from Game dictionary.
    document.getElementById("Dictionary").innerHTML = Game.Name;
}