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
            echo "TESTING!!"
        }

        stage("DEPLOY")
        {
            echo 'DEPLOY'
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