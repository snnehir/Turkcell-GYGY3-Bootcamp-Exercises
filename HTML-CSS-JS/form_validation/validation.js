function validate() {
    var requiredInputs = document.getElementsByClassName("required")
    let isValid = true
    let validationCount = requiredInputs.length
    for (let i = 0; i < requiredInputs.length; i++) {
        let element = requiredInputs[i]
        isValid = isRequired(element)

        if (isValid && element.getAttribute("id") === "textPassword") {
            isValid = passwordFormatCheck(element)
        }

        if (!isValid) {
            validationCount--;
        }
    };
    console.log(validationCount)
    return validationCount === requiredInputs.length
}

function isRequired(element) {
    let value = element.value
    let span = element.getAttribute("data-target")
    if (value === '') {
        let message = element.getAttribute("data-message")
        document.getElementById(span).innerText = message
        return false
    }
    else {
        document.getElementById(span).innerText = ''
        return true
    }
}

function passwordFormatCheck(element) {
    let value = element.value
    if (value.length < 6) {
        let message = element.getAttribute("data-format-message")
        let span = element.getAttribute("data-target")
        document.getElementById(span).innerText = message
        return false
    }
    return true
}