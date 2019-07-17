using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;

namespace mathletics
{

    internal class QuizUpdate : IHostedService, IDisposable
    {

        private Timer updateTimer;


        public void UpdateServer(object state)
        {
            MathleticsData.CreateQuiz(Quizmaster.BuildQuiz());
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            updateTimer = new Timer(UpdateServer, null, TimeSpan.Zero, TimeSpan.FromSeconds(20));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            updateTimer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            updateTimer?.Dispose();
        }
    }
}