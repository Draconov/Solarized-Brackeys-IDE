function getNameAndVersion(): String {

    function getProductName(): String {
        return "Flash Player";
    }

    function getVersion(): String {
        return "10";
    }

    return (getProductName() + " " + getVersion());
}

trace(getNameAndVersion()); // Flash Player 10

var objVar: Object = { x:10, y:15 };
trace(objVar.x, objVar.y);