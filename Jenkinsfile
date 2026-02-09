pipeline {
    agent any

    triggers {
        pollSCM('H/5 * * * *')
    }

    environment {
        TARGET_WS = 'C:\\Temp\\debricked-workspace\\CDF SAS'
    }

    stages {

        stage('Checkout') {
            steps {
                checkout([
                    $class: 'GitSCM',
                    branches: [[name: '*/devcsharp']],
                    userRemoteConfigs: [[
                        url: 'https://github.com/bnava/tecnosfortify.git',
                        credentialsId: 'github-token'
                    ]]
                ])
            }
        }

        stage('Debricked Scan') {
            steps {
                bat '''
                if exist "%TARGET_WS%" rmdir /s /q "%TARGET_WS%"

                mkdir "%TARGET_WS%"

                xcopy "%WORKSPACE%" "%TARGET_WS%" /E /I /Y

                cd /d "%TARGET_WS%"

                powershell.exe -NoProfile -ExecutionPolicy Bypass ^
                  -File C:\\Users\\Administrator\\Desktop\\node-express-typescript\\DebrickedIntegration.ps1 ^
                  -version v1 ^
                  -appname "Gradle Prueba-GTO9" ^
                  -workspace "%TARGET_WS%"

                cd /d "%WORKSPACE%"

                echo Termino
                '''
            }
        }

        stage('Fortify Scan') {
            steps {
                fortifyScan(
                    buildId: 'otlatamprueba',
                    scanFile: 'prueba',
                    maxHeap: '8000',
                    projectScanType: otherScanType(
                        includes: "${WORKSPACE}/**"
                    ),
                    uploadSSC: [
                        appName: 'Gradle Prueba-GTO9',
                        appVersion: 'v1'
                    ],
                    verbose: true
                )
            }
        }
    }

    post {
        success {
            echo '✅ Pipeline completado correctamente'
        }
        failure {
            echo '❌ Falló el pipeline'
        }
    }
}
