using PucRio.PSS.DesignPatterns.Bridge;
using System;
using System.Collections.Generic;

namespace PucRio.PSS.DesignPatterns
{
    class Program
    {
        static int Main(string[] args)
        {
        	if (args.Length < 1)
			{
				Console.Error.WriteLine("The desired example to be ran should be specified");
				return 1;
			}

			var desiredExample = args[0];
			if (!Examples.TryGetValue(desiredExample, out var example))
			{
				Console.Error.WriteLine($"The desired example '{desiredExample}' isn't available");
				return 2;
			}

			try
			{
				example();
				return 0;
			}
			catch
			{
				Console.Error.WriteLine($"An unexpected error has occurred");
				return 3;
			}
        }

		static readonly Dictionary<string, Action> Examples = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase)
		{
			["bridge"] = () =>
			{
                Console.WriteLine("EXECUTING THE 'BRIDGE' DP EXAMPLE");

                IDeviceController deviceController;
                var radio = new Radio();
                var television = new Television();

                Console.WriteLine("\n> RADIO + REMOTE CONTROLLER:");
                deviceController = new RemoteController(radio);
                deviceController.TurnOn();
                deviceController.ChannelUp();
                deviceController.VolumeUp();
                deviceController.VolumeDown();
                deviceController.ChannelDown();
                deviceController.TurnOff();

                Console.WriteLine("\n> TELEVISION + REMOTE CONTROLLER:");
                deviceController = new RemoteController(television);
                deviceController.TurnOn();
                deviceController.ChannelUp();
                deviceController.VolumeUp();
                deviceController.VolumeDown();
                deviceController.ChannelDown();
                deviceController.TurnOff();


                FancyRemoteController fancyDeviceController;

                Console.WriteLine("\n> RADIO + FANCY REMOTE CONTROLLER:");
                fancyDeviceController = new FancyRemoteController(radio);
                fancyDeviceController.TurnOn();
                fancyDeviceController.ChannelUp();
                fancyDeviceController.VolumeUp();
                fancyDeviceController.Mute();
                fancyDeviceController.UnMute();
                fancyDeviceController.VolumeDown();
                fancyDeviceController.ChannelDown();
                fancyDeviceController.TurnOff();


                Console.WriteLine("\n> TELEVISION + FANCY REMOTE CONTROLLER:");
                fancyDeviceController = new FancyRemoteController(television);
                fancyDeviceController.TurnOn();
                fancyDeviceController.ChannelUp();
                fancyDeviceController.VolumeUp();
                fancyDeviceController.Mute();
                fancyDeviceController.UnMute();
                fancyDeviceController.VolumeDown();
                fancyDeviceController.ChannelDown();
                fancyDeviceController.TurnOff();
			},
			["memento"] = () =>
            { 
                Console.WriteLine("EXECUTING THE 'MEMENTO' DP EXAMPLE");
				throw new NotImplementedException();
			},
			["factoryMethod"] = () =>
			{
                Console.WriteLine("EXECUTING THE 'FACTORY METHOD' DP EXAMPLE");
				throw new NotImplementedException();
			},
			["command"] = () =>
			{
                Console.WriteLine("EXECUTING THE 'COMMAND' DP EXAMPLE");
				throw new NotImplementedException();
			}
		};
    }
}
