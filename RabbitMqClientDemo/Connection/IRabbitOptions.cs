﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMqClient
{
    public interface IRabbitOptions
    {
        string Host { get; }

        string Username { get; }

        string Password { get; }

        string VirtualHost { get; }

         string ExchangeName { get; set; }
         string QueueName { get; set; }
         string RoutingKey { get; set; }
    }
}
