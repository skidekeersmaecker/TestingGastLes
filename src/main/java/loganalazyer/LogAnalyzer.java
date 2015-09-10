package loganalazyer;

import java.util.List;

public class LogAnalyzer {
    private LogSource logSource;
    private Logger logger;

    public LogAnalyzer(LogSource logSource, Logger logger) {
        this.logSource = logSource;
        this.logger = logger;
    }

    public void analyze() {
        List<String> lines = logSource.getLines();

        for (String line : lines) {
            if (line.contains("Error: ")) {
                logger.logError(line);
            } else if (line.contains("Info: ")) {
                logger.logInfo(line);
            }
        }

    }
}
