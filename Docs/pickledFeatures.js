jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "Rendering\\Views with partials.feature",
      "Feature": {
        "Name": "Views with partials",
        "Description": "\tIn order to test a view including a child partial\r\n\tI want to render the parent view and get HTML including the child content",
        "FeatureElements": [
          {
            "Name": "Render view with partial",
            "Slug": "render-view-with-partial",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have an instance of a view with a partial",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have registered the partial with ViewsUnderTest",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I use the RenderAsHtml extension",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result should be a HtmlDocument containing HTML from the partial",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "Rendering\\View with model.feature",
      "Feature": {
        "Name": "View with model",
        "Description": "\tIn order to test a view with a model\r\n\tI want to pass a model when I render it",
        "FeatureElements": [
          {
            "Name": "Render view with model",
            "Slug": "render-view-with-model",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have a view and a model",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I use the RenderAsHtml extension with the model",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result should display values from the model",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "Rendering\\Standalone views.feature",
      "Feature": {
        "Name": "Standalone views",
        "Description": "\tIn order to test a simple view\r\n\tI want to render a view instance as HTML with one method call",
        "FeatureElements": [
          {
            "Name": "Render simple view",
            "Slug": "render-simple-view",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have an instance of a simple view",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I use the RenderAsHtml extension",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result should be a HTML document",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "Calling Controllers\\Calling controllers from views.feature",
      "Feature": {
        "Name": "Calling controllers from views",
        "Description": "\tIn order to test views that call controllers\r\n\tI want to do as little plumbing as possible",
        "FeatureElements": [
          {
            "Name": "Call a controller from a view",
            "Slug": "call-a-controller-from-a-view",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have a view that calls a controller",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have registered the controller with ControllersUnderTest",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have registered the partial with ViewsUnderTest",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I use the RenderAsHtml extension",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result should include HTML from the controller action",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Summary": {
    "Tags": [],
    "Folders": [
      {
        "Folder": "Rendering",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "Calling Controllers",
        "Total": 1,
        "Passing": 1,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "Rendering",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "Calling Controllers",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 4,
      "Passing": 4,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 4,
      "Passing": 4,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "GeneratedOn": "4 september 2016 00.03.45"
  }
});