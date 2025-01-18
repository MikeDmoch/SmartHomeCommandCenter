using SmartHomeCommandCenter;

static void Main()
{
    var light = new Light();
    var thermostat = new Thermostat();
    var audioSystem = new AudioSystem();

    var smartHomeManager = new SmartHomeManager();

    var turnOnLight = new switch(light);
    var setTemperature = new SetTemperature(thermostat, 22);
    var playMusic = new PlayMusic(audioSystem, "HipHop");

    smartHomeManager.ExecuteCommand(turnOnLight);
    smartHomeManager.ExecuteCommand(setTemperature);
    smartHomeManager.ExecuteCommand(playMusic);

    smartHomeManager.Undo();
    smartHomeManager.Undo();
}