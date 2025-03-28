CREATE TABLE customer (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    credit_balance INT NOT NULL DEFAULT 0
);

CREATE TABLE play_type (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE play (
    id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    lines INT NOT NULL,
    play_type_id INT NOT NULL,
    CONSTRAINT fk_play_type FOREIGN KEY (play_type_id) REFERENCES play_type(id) ON DELETE CASCADE
);

CREATE TABLE invoice (
    id SERIAL PRIMARY KEY,
    customer_id INT NOT NULL,
    issue_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_invoice_customer FOREIGN KEY (customer_id) REFERENCES customer(id) ON DELETE CASCADE
);

CREATE TABLE performance (
    id SERIAL PRIMARY KEY,
    invoice_id INT NOT NULL,
    play_id INT NOT NULL,
    audience INT NOT NULL,
    time TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    credits_earned INT NOT NULL,
    cal_performance decimal NOT NULL,
    CONSTRAINT fk_performance_invoice FOREIGN KEY (invoice_id) REFERENCES invoice(id) ON DELETE CASCADE,
    CONSTRAINT fk_performance_play FOREIGN KEY (play_id) REFERENCES play(id) ON DELETE CASCADE
);

INSERT INTO play_type (name) VALUES
                                 ('Comedy'),
                                 ('Tragedy'),
                                 ('Historical');
