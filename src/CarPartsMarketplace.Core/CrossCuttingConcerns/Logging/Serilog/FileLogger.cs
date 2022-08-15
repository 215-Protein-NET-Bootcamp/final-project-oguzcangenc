using CarPartsMarketplace.Core.Constants;
using CarPartsMarketplace.Core.DependencyResolvers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

namespace CarPartsMarketplace.Core.CrossCuttingConcerns.Logging.Serilog;

public class FileLogger : LoggerServiceBase
{
    /// <summary>
    /// File Logger Configuration
    /// </summary>
    public FileLogger()
    {
        var logConfig = ServiceTool.ServiceProvider.GetService<IOptions<FileLogConfiguration>>().Value ?? throw new Exception(Messages.FileLogConfigurationNotFound);
        var logFilePath = string.Format("{0}{1}", Directory.GetCurrentDirectory() + logConfig.FolderPath, ".txt");
        Logger = new LoggerConfiguration()
            .WriteTo.File(
                logFilePath,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: null,
                fileSizeLimitBytes: 5000000,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }
}