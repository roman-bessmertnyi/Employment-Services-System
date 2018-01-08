SELECT j.*, u.email, t.job_type

FROM (([job_post] j
INNER JOIN (SELECT id, email FROM [user_account]) u ON j.posted_by_id = u.id)
INNER JOIN (SELECT id, job_type FROM [job_type]) t ON j.job_type_id = t.id)