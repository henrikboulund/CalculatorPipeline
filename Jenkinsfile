pipeline{
    agent any
    triggers
    {
        pollSCM("0 * * * *")
    }

    stages{
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
            steps{
                echo "TESTING!!"
            }
            
        }

        stage("DEPLOY")
        {
            steps{
                sh "dotnet test"
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