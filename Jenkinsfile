pipeline{
    agent any
    triggers
    {
        pollSCM("* * * * *")
    }

    stages{
        stage("STARTUP")
        {
            steps{
                dir("Tests")
                {
                    sh "rm -rf TestResults"
                }
            }
        }
        stage("BUILD"){
            steps{

                sh "dotnet build CalculatorPipeline.sln"
            }
            post{
                always{
                    echo "========always========"
                }
                success{
                    echo "========A executed successfully========"
                }
                failure{
                    echo "========A execution failed========"
                }
            }
        }

        stage("TEST")
        {
            steps
            {
                dir("Tests")
                {
                    sh "dotnet add package coverlet.collector"
                    sh "dotnet test --collect:'XPlat Code Coverage'"
                }
            }
            post
            {
                success
                {
                    archiveArtifacts "Tests/TestResults/*/coverage.cobertura.xml"
                    publishCoverage adapters: [istanbulCoberturaAdapter(path: 'Tests/TestResults/*/coverage.cobertura.xml', thresholds: [[failUnhealthy: true, thresholdTarget: 'Conditional', unhealthyThreshold: 80.0, unstableThreshold: 50.0]])], checksName: '', sourceFileResolver: sourceFiles('NEVER_STORE')
                }
            }
            
        }

        stage("DEPLOY")
        {
            steps{
                echo "DEPLOY!!!"
            }
            
        }
    }
    post{
        always{
            echo "========always========"
        }
        success{
            echo "========pipeline executed successfully ========"
        }
        failure{
            echo "========pipeline execution failed========"
        }
    }
}
