using PucRio.PSS.DesignPatterns.Bridge;
using PucRio.PSS.DesignPatterns.Command;
using PucRio.PSS.DesignPatterns.FactoryMethod;
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

                OAuthEngine engine;

                Console.WriteLine("\n> GOOGLE:");
                engine = new GoogleOAuthEngine();
                engine.GetUserInformation();

                Console.WriteLine("\n> FACEBOOK:");
                engine = new FacebookOAuthEngine();
                engine.GetUserInformation();

                Console.WriteLine("\n> REDDIT:");
                engine = new RedditOAuthEngine();
                engine.GetUserInformation();
			},
			["command"] = () =>
			{
                Console.WriteLine("EXECUTING THE 'COMMAND' DP EXAMPLE");

                var broker = new Broker();

                broker.TakeOrder(new BuyStock(new Stock("GGBR4")));
                broker.TakeOrder(new BuyStock(new Stock("GOAU4")));
                broker.TakeOrder(new SellStock(new Stock("CSNA3")));
                broker.TakeOrder(new BuyStock(new Stock("BRAP4")));
                broker.TakeOrder(new SellStock(new Stock("VALE3")));
                broker.TakeOrder(new BuyStock(new Stock("ENBR3")));
                broker.TakeOrder(new BuyStock(new Stock("KLBN11")));
                broker.TakeOrder(new SellStock(new Stock("SUZB3")));
                broker.TakeOrder(new SellStock(new Stock("CSAN3")));

                broker.PlaceOrders();
			}
		};
    }
}
