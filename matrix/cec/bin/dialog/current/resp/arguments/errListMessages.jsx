fetch('/api/users', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ email, password })
})
    .then(response => {
        if (!response.ok) {
            return response.json().then(errorData => {
                // Assuming errorData.errors is an array of error messages
                errorData.errors.forEach(err => console.error(err.msg));
                throw new Error('Validation failed');
            });
        }
        return response.json();
    })
    .catch(error => {
        console.error('Error name:', error.name);
        console.error('Error message:', error.message);
    });
